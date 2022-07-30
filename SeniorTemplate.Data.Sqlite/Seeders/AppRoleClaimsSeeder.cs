using NeerCore.Data.EntityFramework.Abstractions;
using NeerCore.Security;
using SeniorTemplate.Core.Constants;
using SeniorTemplate.Data.Entities;

namespace SeniorTemplate.Data.Seeders;

public class AppRoleClaimsSeeder : IEntityDataSeeder<AppRoleClaim>
{
    public IEnumerable<AppRoleClaim> Data => new AppRoleClaim[]
    {
        new()
        {
            Id = 1,
            RoleId = 2,
            ClaimType = Claims.Permission,
            ClaimValue = Permissions.Admin
        }
    };
}