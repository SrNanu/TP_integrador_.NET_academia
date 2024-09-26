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
    public DbSet<ModuloUsuario> ModuloUsuarios { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<DocenteCurso> DocenteCursos { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Comision> Comisiones { get; set; }
    public DbSet<AlumnoInscripcion> AlumnoInscripciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=AcademiaDb");
    }

    //Si lo queremos en MySQL
    /*
     optionsBuilder.UseMySql("Server=localhost;Database=Academia;User=root;Password=root;",
            ServerVersion.AutoDetect("Server=localhost;Database=Academia;User=root;Password=root;"));
    }
     */
}
