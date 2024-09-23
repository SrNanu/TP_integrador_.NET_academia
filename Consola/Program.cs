

// See https://aka.ms/new-console-template for more information
using Dominio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<UniversidadDbContext>();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwagger();


        app.MapGet("/", () => "Hello World!");


        app.MapGet("/usuarios", async (UniversidadDbContext context) =>
        {
            List<Usuario> usuarios = await context.Usuarios.ToListAsync();

            return Results.Ok(usuarios);
        }
        );



        app.MapGet("/usuarios/{id}", async (int id, UniversidadDbContext context) =>
            await context.Usuarios.FindAsync(id) is Usuario alumno
                ? Results.Ok(alumno)
                : Results.NotFound());


        app.MapPost("/usuarios", async (Usuario alumno, UniversidadDbContext context) =>
        {
            context.Usuarios.Add(alumno);
            await context.SaveChangesAsync();

            return Results.Created($"/usuarios/{alumno.Id}", alumno);
        });

        app.MapDelete("/usuarios/{id}", async (int id, UniversidadDbContext context) =>
        {
            var alumno = await context.Usuarios.FindAsync(id);

            if (alumno != null)
            {
                context.Usuarios.Remove(alumno);
                await context.SaveChangesAsync();
                Results.NoContent();
            }
            else
            {
                Results.NotFound(new { message = "Alumno not found" });
            }

        }
        );
        app.MapPut("/usuarios/{id}", async (int id, Usuario updatedAlumno, UniversidadDbContext context) =>
        {
            var existingAlumno = await context.Usuarios.FindAsync(id);

            if (existingAlumno != null)
            {
                existingAlumno.Apellido = updatedAlumno.Apellido;
                existingAlumno.Nombre = updatedAlumno.Nombre;
                existingAlumno.Legajo = updatedAlumno.Legajo;
                existingAlumno.Direccion = updatedAlumno.Direccion;

                context.Usuarios.Update(existingAlumno);
                await context.SaveChangesAsync();
                return Results.NoContent();

            }
            else
            {
                return Results.NotFound(new { message = "Alumno not found" });
            }

        }
        );
    }
}