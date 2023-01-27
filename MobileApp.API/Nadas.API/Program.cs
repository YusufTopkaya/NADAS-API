using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Nadas.API.Business.Concrete;
using Nadas.API.Business.Containers.MicrosoftIoC;
using Nadas.API.Business.ExtensionMethods;
using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Serilog;
using System.Text.Json;
using System.Text.Json.Serialization;
using TechBuddy.Middlewares.RequestResponse;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration(conf =>
{
    conf.AddJsonFile("Configurations/secrets.json",false);
});

builder.Host.AddCustomSerilog("Nadas");
// Add services to the container.
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDependencies(builder.Configuration);
builder.Services.AddCors(cors =>
{
    cors.AddPolicy("LocalHost",policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    opt.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks().AddDbContextCheck<NadasContext>();
builder.Services.AddHealthChecksUI().AddInMemoryStorage();
builder.Services.AddCoreAdmin();

var app = builder.Build();

var dbContext = app.Services.GetRequiredService<NadasContext>();

dbContext.Database.Migrate();


app.UseSwagger();
app.UseSwaggerUI();

app.AddTBRequestResponseMiddleware(opt =>
{
    opt.UseLogger(app.Services.GetRequiredService<ILoggerFactory>(), loggingOptions =>
    {
        loggingOptions.UseSeparateContext = true;
        var fields = Enum.GetValues(typeof(LogFields)).Cast<LogFields>();
        loggingOptions.LoggingFields.AddRange(fields);
    });
});

app.Use((context,next) =>
{
    Log.Information(new String('-',100));
    Log.Information(DateTime.Now.ToString());
    Log.Information(new String('-', 100));
    return next();
});

//app.UseHealthChecks("/health");
app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});
app.MapHealthChecksUI();
app.UseStaticFiles();

app.UseRouting();
app.UseCors("LocalHost");
app.UseAuthorization();

app.UseEndpoints(ep =>
{
    ep.MapControllers();
    ep.MapDefaultControllerRoute();
});

app.Run();
