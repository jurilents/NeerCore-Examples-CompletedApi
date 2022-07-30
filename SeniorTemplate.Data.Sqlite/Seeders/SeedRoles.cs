using NeerCore.Data.EntityFramework.Abstractions;
using SeniorTemplate.Data.Entities;

namespace SeniorTemplate.Data.Seeders;

public class AppRolesSeeder : IEntityDataSeeder<AppRole>
{
    public IEnumerable<AppRole> Data => new AppRole[]
    {
        new()
        {
            Id = 1,
            Name = "user",
            NormalizedName = "USER",
        },
        new()
        {
            Id = 2,
            Name = "admin",
            NormalizedName = "ADMIN"
        }
    };
}