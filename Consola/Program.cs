using System;
using System.Linq;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Dominio.Usuario;

public class Program
{
    public static void Main(string[] args)
    {
        CrearUsuario(1, "Juan Cruz", "Mondino", 12345, "Urquiza 123");

        LeerUsuario(12345);

        ActualizarUsuario(12345);

        LeerUsuario(12345);

        EliminarUsuario(12345);
    }

    public static void CrearUsuario(int id, string nombre, string apellido, int legajo, string direccion)
    {
        using (var context = new AcademiaContext())
        {
            var usuario = new Usuario
            {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Legajo = legajo,
                Direccion = direccion
            };

            context.Usuarios.Add(usuario);
            context.SaveChanges();
            Console.WriteLine($"Usuario creado: ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, " +
                              $"Legajo: {usuario.Legajo}, Dirección: {usuario.Direccion}");
        }
    }

    public static void LeerUsuario(int legajo)
    {
        using (var context = new AcademiaContext())
        {
            var usuario = context.Usuarios.FirstOrDefault(u => u.Legajo == legajo);
            if (usuario != null)
            {
                Console.WriteLine($"Usuario encontrado: ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, " +
                                  $"Legajo: {usuario.Legajo}, Dirección: {usuario.Direccion}");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado.");
            }
        }
    }

    public static void ActualizarUsuario(int legajo)
    {
        int decision = 9;

        while (decision > 3 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- Nombre" +
            "              \n   2- Apellido" +
            "              \n   3- Dirección" +
            "              \n   0- Salir");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Legajo == legajo);
                if (usuario != null)
                {
                    switch (decision)
                    {
                        case 1:
                            Console.Write("\nIngrese el nuevo nombre: ");
                            usuario.Nombre = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("\nIngrese el nuevo apellido: ");
                            usuario.Apellido = Console.ReadLine();
                            break;

                        case 3:
                            Console.Write("\nIngrese la nueva dirección: ");
                            usuario.Direccion = Console.ReadLine();
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Usuario actualizado: ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, " +
                                      $"Legajo: {usuario.Legajo}, Dirección: {usuario.Direccion}");
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
        }
    }

    public static void EliminarUsuario(int legajo)
    {
        using (var context = new AcademiaContext())
        {
            var usuario = context.Usuarios.FirstOrDefault(a => a.Legajo == legajo);
            if (usuario != null)
            {
                context.Alumnos.Remove(usuario);
                context.SaveChanges();
                Console.WriteLine($"AlUsuarioumno eliminado: ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, " +
                                  $"Legajo: {usuario.Legajo}, Dirección: {usuario.Direccion}");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado.");
            }
        }
    }
}