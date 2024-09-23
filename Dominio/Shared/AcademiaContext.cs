using System;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class AcademiaContext : DbContext
{
    public AcademiaContext()
    {
        this.Database.EnsureCreated();
    }

    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=Academia;User=root;Password=0717;",
            ServerVersion.AutoDetect("Server=localhost;Database=Academia;User=root;Password=0717;"));
    }
}
