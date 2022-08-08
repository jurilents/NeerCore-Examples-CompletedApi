using NeerCore.Api;
using NeerCore.Api.Extensions;
using NeerCore.Api.Extensions.Swagger;
using NeerCore.Application.Extensions;
using NeerCore.DependencyInjection.Extensions;
using NeerCore.Logging;
using NeerCore.Logging.Extensions;
using NeerCore.Mapping.Extensions;
using SeniorTemplate.Data;

var logger = LoggerInstaller.InitFromCurrentEnvironment();

try
{
    var app = BuildWebApp();

    if (app.Configuration.GetSwaggerSettings().Enabled)
        app.UseCustomSwagger();

    app.UseCors(CorsPolicies.AcceptAll);
    app.UseHttpsRedirection();

    app.UseRequestLocalization();
    app.UseCustomExceptionHandler();

    app.MapControllers();
    app.Run();
}
catch (Exception e)
{
    logger.Fatal(e);
}
finally
{
    logger.Info("Application is now stopping");
    NLog.LogManager.Shutdown();
}

// ==========================================

WebApplication BuildWebApp()
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Logging.ConfigureNLogAsDefault();

    builder.Services.AddSqlServerDatabase(builder.Configuration);

    builder.Services.AddMediatorApplication();
    builder.Services.AddHashids(builder.Configuration.GetSection("Hashids").Bind);
    builder.Services.ConfigureAllOptions();
    builder.Services.RegisterAllMappers();
    builder.Services.AddAllServices();

    builder.Services.AddNeerApiServices();
    builder.Services.AddNeerControllers();

    return builder.Build();
}