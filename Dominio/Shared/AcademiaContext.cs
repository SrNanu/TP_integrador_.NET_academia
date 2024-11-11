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

        //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6HBL1R6\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Encrypt=False"); // JUAN CRUZ - Notebook
        //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-KD3CGEG\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Encrypt=False"); // JUAN CRUZ - Pc

        //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6HBL1R6\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Encrypt=False"); //LUCIO
        
        optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Encrypt=False"); //universal


    }
}
