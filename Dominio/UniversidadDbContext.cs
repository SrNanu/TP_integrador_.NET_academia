using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace WebApp
{
    public class UniversidadDbContext : DbContext
    {
        public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server = localhost; port=3307; Database = Dbnet; User = root; Password = 1234; Pooling = true",
                new MySqlServerVersion(new Version(8, 0, 37)));

                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            }
        }
    }
}
