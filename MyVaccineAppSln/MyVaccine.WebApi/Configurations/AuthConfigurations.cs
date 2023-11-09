﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MyVaccine.WebApi.Models;

namespace MyVaccine.WebApi.Configurations;

public static class AuthConfigurations
{
    public static IServiceCollection SetMyVaccineAuthConfiguration(this IServiceCollection services)
    {
        services.AddIdentity<IdentityUser, IdentityRole>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 8;

          //  options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
          //  options.Lockout.MaxFailedAccessAttempts = 5;
        }
        ).AddEntityFrameworkStores<MyVaccineAppDbContext>()
        .AddDefaultTokenProviders();

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = false,
                //ValidIssuer = "tu_issuer",
                //ValidAudience = "tu_audience",
                //IssuerSigningKeys = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("tu_clave_secreta")),
                //ClockSkew = TimeSpan.Zero // Evita un desfase de tiempo opcional
            };

        });

        return services;
    }
}