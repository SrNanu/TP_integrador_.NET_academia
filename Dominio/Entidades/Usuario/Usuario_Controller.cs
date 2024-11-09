using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Usuario_Controller
{
    //Metodos Normales
    public static void AgregarUsuario(Usuario usuario)
    {
        
        using var context = new AcademiaContext();
        
        context.Usuarios.Add(usuario);
        context.SaveChanges();
        
    }

    public static Usuario? GetOneUsuarioId(int id)
    {
        using var context = new AcademiaContext();

        return context.Usuarios.Find(id);
        
    }

    public static Usuario? GetOneUsuarioUsername(string username)
    {
        using var context = new AcademiaContext();

        return  context.Usuarios.FirstOrDefault(u => u.Username == username);

    }

    public static Usuario? GetOneUsuarioMail(string mail)
    {
        using var context = new AcademiaContext();

        return context.Usuarios.FirstOrDefault(u => u.Email == mail);

    }

    public static Usuario? GetOneUsuarioLegajo(int legajo)
    {
        using var context = new AcademiaContext();

        return context.Usuarios.FirstOrDefault(u => u.Legajo == legajo);

    }

    // Metodos Async

    public async Task<IEnumerable<Usuario>> GetDocentes(int idUsuario)     //En vez de IEnumerable podria ir List.
    {
        using var context = new AcademiaContext();

        return await context.Usuarios.Where(ai => (ai.Id == idUsuario && ai.Tipo == TiposUsuarios.Docente)).ToListAsync();
    }

    public static async Task AgregarUsuarioAsync(Usuario usuario)
    {
        using var context = new AcademiaContext();
        context.Usuarios.Add(usuario);
        await context.SaveChangesAsync();
    }

    public static async Task<Usuario?> GetOneUsuarioIdAsync(int id)
    {
        using var context = new AcademiaContext();
        return await context.Usuarios.FindAsync(id);
    }

    public static async Task<Usuario?> GetOneUsuarioUsernameAsync(string username)
    {
        using var context = new AcademiaContext();
        return await context.Usuarios.FirstOrDefaultAsync(u => u.Username == username);
    }

    public static async Task<Usuario?> GetOneUsuarioMailAsync(string mail)
    {
        using var context = new AcademiaContext();
        return await context.Usuarios.FirstOrDefaultAsync(u => u.Email == mail);
    }

    public static async Task<Usuario?> GetOneUsuarioLegajoAsync(int legajo)
    {
        using var context = new AcademiaContext();
        return await context.Usuarios.FirstOrDefaultAsync(u => u.Legajo == legajo);
    }

    //Siguen los normales
    public static IEnumerable<Usuario> GetAllUsuario()
    {
        using var context = new AcademiaContext();

        return context.Usuarios.ToList();
    }

    public static void ActualizarUsuario(Usuario usuario)
    {     
        using var context = new AcademiaContext();
        
        var usuarioToUpdate = context.Usuarios.Find(usuario.Id);

        if (usuarioToUpdate != null)
        {
            usuarioToUpdate.IdPlan = usuario.IdPlan;
            usuarioToUpdate.Nombre = usuario.Nombre;
            usuarioToUpdate.Apellido = usuario.Apellido;
            usuarioToUpdate.FechaNacimiento = usuario.FechaNacimiento;
            usuarioToUpdate.Direccion = usuario.Direccion;
            usuarioToUpdate.Tipo = usuario.Tipo;
            usuarioToUpdate.Telefono = usuario.Telefono;
            usuarioToUpdate.Legajo = usuario.Legajo;
            usuarioToUpdate.Email = usuario.Email;
            usuarioToUpdate.Username = usuario.Username;
            usuarioToUpdate.Password = usuario.Password;
            usuarioToUpdate.Habilitado = usuario.Habilitado;
            usuarioToUpdate.Id = usuario.Id;
            context.SaveChanges();
        } 
    }

    public static void EliminarUsuario(int id)
    {
        using var context = new AcademiaContext();
        
        var usuario = context.Usuarios.Find(id);
        if (usuario != null)
        {
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
        
    }
}
