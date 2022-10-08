using Microsoft.Extensions.Configuration;
using RunLikeTheWind.Domain.Interfaces;
using RunLikeTheWind.Domain.Services;
using RunLikeTheWindAPI.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddControllers();


var apiKey = builder.Configuration.GetSection("ExternalAPI").GetSection("WeatherKey").Value;
var apiEndPoint = builder.Configuration.GetSection("ExternalAPI").GetSection("ApiEndPoint").Value;


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IRunLikeTheWindServices, RunLikeTheWindServices>();
builder.Services.AddTransient<IWeatherforecastService>(_ =>new WeatherForecastServices(apiKey,apiEndPoint));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
