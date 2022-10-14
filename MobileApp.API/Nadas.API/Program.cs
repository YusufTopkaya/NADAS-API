using Microsoft.EntityFrameworkCore;
using Nadas.API.Business.Containers.MicrosoftIoC;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("LocalHost");
app.UseAuthorization();

app.MapControllers();

app.Run();
