using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace SeniorTemplate.Application.Settings;

public record JwtSettings
{
    public SecurityKey? Secret { get; set; }
    public TimeSpan AccessTokenLifetime { get; set; }
    public TimeSpan RefreshTokenLifetime { get; set; }
}

public class JwtSettingsConfigurator : IConfigureOptions<JwtSettings>
{
    private readonly IConfiguration _configuration;
    public JwtSettingsConfigurator(IConfiguration configuration) => _configuration = configuration;

    public void Configure(JwtSettings options)
    {
        options.Secret = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]));
        options.AccessTokenLifetime = TimeSpan.TryParse(_configuration["Jwt:AccessTokenLifetime"], out var val) ? val : TimeSpan.FromMinutes(10);
        options.RefreshTokenLifetime = TimeSpan.TryParse(_configuration["Jwt:RefreshTokenLifetime"], out val) ? val : TimeSpan.FromDays(30);
    }
}