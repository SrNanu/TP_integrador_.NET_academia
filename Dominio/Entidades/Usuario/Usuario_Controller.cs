using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Dominio.Entidades;

public class Usuario_Controller
{
    //Metodos Normales
    public static void AgregarUsuario(Usuario usuario)
    {
        
        using var context = new AcademiaContext();

        // Llamadas a los métodos de validación
        Validador.ValidarTextoNoVacio(usuario.Nombre, "Nombre");
        Validador.ValidarTextoNoVacio(usuario.Apellido, "Apellido");
        Validador.ValidarEmailUnico(usuario.Email, context);
        Validador.ValidarLegajoUnico(usuario.Legajo, context);
        Validador.ValidarUsernameUnico(usuario.Username, context);

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
            // Validaciones
            Validador.ValidarTextoNoVacio(usuario.Nombre, "Nombre");
            Validador.ValidarTextoNoVacio(usuario.Apellido, "Apellido");
            Validador.ValidarTextoNoVacio(usuario.Username, "Username");
            Validador.ValidarTextoNoVacio(usuario.Email, "Email");

            // Validar unicidad de Email (excluyendo el usuario actual)
            if (usuario.Email != usuarioToUpdate.Email)
            {
                Validador.ValidarEmailUnico(usuario.Email, context);
            }

            // Validar unicidad de Legajo (excluyendo el usuario actual)
            if (usuario.Legajo != usuarioToUpdate.Legajo)
            {
                Validador.ValidarLegajoUnico(usuario.Legajo, context);
            }

            // Validar unicidad de Username (excluyendo el usuario actual)
            if (usuario.Username != usuarioToUpdate.Username)
            {
                Validador.ValidarUsernameUnico(usuario.Username, context);
            }

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
