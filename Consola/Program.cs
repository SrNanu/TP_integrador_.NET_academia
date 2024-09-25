using System;
using System.Linq;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // ** CRUD Usuario **
        Usuario_Controller.CrearUsuario(/*1,*/ 1, "Juan Cruz", "Mondino", new DateTime(2000, 10, 23), "Urquiza 123", "3364592427",
                 12345, "juan.mondino@example.com", "juan.c", "contraseñaSegura");
        Usuario_Controller.LeerUsuario(12345);
        Usuario_Controller.ActualizarUsuario(12345);
        Usuario_Controller.LeerUsuario(12345);
        Usuario_Controller.EliminarUsuario(12345);
        // Estará bien referenciado de esta forma? con la clase por delante
    }
}