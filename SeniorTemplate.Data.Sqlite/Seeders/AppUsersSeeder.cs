using Microsoft.AspNetCore.Identity;
using NeerCore.Data.EntityFramework.Abstractions;
using SeniorTemplate.Data.Entities;

namespace SeniorTemplate.Data.Seeders;

public class AppUsersSeeder : IEntityDataSeeder<AppUser>
{
    private static readonly PasswordHasher<AppUser?> Hasher = new();

    public IEnumerable<AppUser> Data => new AppUser[]
    {
        new()
        {
            Id = 1,
            UserName = "aspadmin",
            NormalizedUserName = "ASPADMIN",
            Email = "aspadmin@asp.net",
            NormalizedEmail = "ASPADMIN@ASP.NET",
            EmailConfirmed = true,
            PasswordHash = Hasher.HashPassword(null, "aspX1234"),
            SecurityStamp = Guid.NewGuid().ToString()
        },
    };
}