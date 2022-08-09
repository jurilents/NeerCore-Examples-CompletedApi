using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeerCore.Data.EntityFramework.Abstractions;
using NeerCore.Data.EntityFramework.Design;
using NeerCore.Data.EntityFramework.Extensions;
using SeniorTemplate.Data.Entities;

namespace SeniorTemplate.Data.Context;

public class SqliteDbContext : IdentityDbContext<AppUser, AppRole, int,
    AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>, IDatabaseContext
{
    public SqliteDbContext(DbContextOptions options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureEntities(config =>
        {
            config.EngineStrategy = DbEngineStrategy.Sqlite;
            config.DateTimeKind = DateTimeKind.Utc;
        });
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);

        configurationBuilder.ConfigureDataConversions();
    }
}