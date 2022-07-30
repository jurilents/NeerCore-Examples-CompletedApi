using NeerCore.Data.EntityFramework.Abstractions;
using NeerCore.Security;
using SeniorTemplate.Core.Constants;
using SeniorTemplate.Data.Entities;

namespace SeniorTemplate.Data.Seeders;

public class AppUserClaimsSeeder : IEntityDataSeeder<AppUserClaim>
{
    public IEnumerable<AppUserClaim> Data => new AppUserClaim[]
    {
        new()
        {
            Id = 1,
            UserId = 1,
            ClaimType = Claims.Permission,
            ClaimValue = Permissions.Master
        }
    };
}