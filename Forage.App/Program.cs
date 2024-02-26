using Forage.App.ServiceRegistrations;
using Forage.Core.Options;
using Forage.Service.Validations.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
using Forage.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Register(builder.Configuration);
builder.Services.AddScope(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(o => o.AddPolicy("Forage", builder =>
{
    builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
}));
// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("Forage");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
