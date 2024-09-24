using System;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

public class AcademiaContext : DbContext
{
    public AcademiaContext()
    {
        this.Database.EnsureCreated();
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Plan> Planes { get; set; }
    public DbSet<Modulo> Modulos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=Academia;User=root;Password=0717;",
            ServerVersion.AutoDetect("Server=localhost;Database=Academia;User=root;Password=0717;"));
    }
}
