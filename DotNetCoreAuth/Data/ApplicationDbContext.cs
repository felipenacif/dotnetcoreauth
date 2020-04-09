using System;
using System.Collections.Generic;
using System.Text;
using DotNetCoreAuth.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
