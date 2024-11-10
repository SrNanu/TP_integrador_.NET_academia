using System;
using Microsoft.EntityFrameworkCore;

public class AcademiaContext : DbContext
{
    public AcademiaContext()
    {
        this.Database.EnsureCreated();
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Plan> Planes { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<DocenteCurso> DocenteCursos { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Comision> Comisiones { get; set; }
    public DbSet<AlumnoInscripcion> AlumnoInscripciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        
        //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=AcademiaDb"); //SANTINO
        
        //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6HBL1R6\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Encrypt=False"); JUAN CRUZ

        optionsBuilder.UseSqlServer(@"Data Source=HPLAPTOP-LUCIO\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Encrypt=False"); //LUCIO


    }
}
