using Forage.Core.Options;
using Forage.Service.Validations.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
using Forage.Service;
using Forage.Data.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScope(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<ForageAppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddHttpContextAccessor();

// Remove this redundant call to AddSwaggerGen()
// builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Forage.App API",
        Version = "v1",
        Description = "An API to perform Employee operations",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "John Walkner",
            Email = "John.Walkner@gmail.com",
            Url = new Uri("https://twitter.com/jwalkner"),
        },
        License = new OpenApiLicense
        {
            Name = "Employee API LICX",
            Url = new Uri("https://example.com/license"),
        }
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opt =>
{
    byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(builder.Configuration["Security:Secret"]);
    if (keyBytes.Length < 64) // Check if the key size is less than 512 bits (64 bytes)
    {
        throw new ArgumentException("JWT Secret key must be at least 64 characters long (512 bits).");
    }

    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidAudience = builder.Configuration["Security:Audience"],
        ValidIssuer = builder.Configuration["Security:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
    };
});


builder.Services.AddCors(o => o.AddPolicy("Forage", builder =>
{
    builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
}));
// Add services to the container.
var app = builder.Build();

if (string.IsNullOrEmpty(app.Configuration.GetValue<String>("KEY")))
    throw new Exception("Error");

// Remove this redundant call to UseSwagger()
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    c.RoutePrefix = string.Empty;
});

//AREA LOCALDA ISLESIN DEYE
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseCors("Forage");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();