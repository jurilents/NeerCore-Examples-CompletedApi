using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NeerCore.Data.EntityFramework.Abstractions;
using NeerCore.DependencyInjection;
using SeniorTemplate.Application.Settings;
using SeniorTemplate.Data.Entities;
using SeniorTemplate.Infrastructure.Extensions;
using SeniorTemplate.Infrastructure.Model;

namespace SeniorTemplate.Infrastructure.Services.Internal;

[Injectable]
public class RefreshTokenGenerator
{
    private readonly JwtSettings _settings;
    private readonly IDatabaseContext _database;
    private readonly DbSet<AppRefreshToken> _refreshTokensSet;
    private readonly IHttpContextAccessor _httpContextAccessor;

    private HttpContext HttpContext => _httpContextAccessor.HttpContext!;

    public RefreshTokenGenerator(IOptions<JwtSettings> optionsAccessor, IHttpContextAccessor httpContextAccessor,
        IDatabaseContext database)
    {
        _database = database;
        _settings = optionsAccessor.Value;
        _httpContextAccessor = httpContextAccessor;
        _refreshTokensSet = _database.Set<AppRefreshToken>();
    }

    public async Task<JwtToken> GenerateAsync(AppUser user, CancellationToken cancel = default)
    {
        DateTime expires = DateTime.UtcNow.Add(_settings.RefreshTokenLifetime);
        string token = GenerateRandomToken();

        _refreshTokensSet.Add(new AppRefreshToken
        {
            Token = token,
            UserId = user.Id,
            IpAddress = HttpContext.GetIPAddress().ToString(),
            UserAgent = HttpContext.GetUserAgent()
        });

        await _database.SaveChangesAsync(cancel);

        return new JwtToken(token, expires);
    }

    public bool IsValid(AppRefreshToken token) =>
        !string.IsNullOrEmpty(token.Token) && token.Created.Add(_settings.RefreshTokenLifetime) > DateTime.UtcNow;

    private static string GenerateRandomToken()
    {
        var randomNumber = new byte[64];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        // To base64 without ending '=='
        string base64 = Convert.ToBase64String(randomNumber)[..^2];
        return base64.Replace('/', '-').Replace('+', '_');
    }
}