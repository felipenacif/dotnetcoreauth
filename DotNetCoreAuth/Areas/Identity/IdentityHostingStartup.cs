﻿using System;
using DotNetCoreAuth.Data;
using DotNetCoreAuth.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DotNetCoreAuth.Areas.Identity.IdentityHostingStartup))]
namespace DotNetCoreAuth.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

                services.AddScoped<IUserClaimsPrincipalFactory<Usuario>, UsuarioClaimsPrincipalFactory>();

            });
        }
    }
}