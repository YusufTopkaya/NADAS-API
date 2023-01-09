using Microsoft.EntityFrameworkCore;
using Nadas.API.Business.Concrete;
using Nadas.API.Business.Containers.MicrosoftIoC;
using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using System.Text.Json.Serialization;
using TechBuddy.Middlewares.RequestResponse;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration(conf =>
{
    conf.AddJsonFile("Configurations/secrets.json",false);
});

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
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IFirestoreService, FirestoreManager>();
builder.Services.AddTransient<INotificationService, NotificationManager>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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
    Console.WriteLine(new String('-',100));
    Console.WriteLine(DateTime.Now.ToString());
    Console.WriteLine(new String('-', 100));
    return next();
});

app.UseCors("LocalHost");
app.UseAuthorization();

app.MapControllers();

app.Run();
