using System;
using System.Linq;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

public class Usuario_Controller
{
    public static void CrearUsuario(Usuario usuario)
    {
        int tipoUsuario;
        do
        {
            Console.Write("\nIngrese el tipo de usuario 1 para profesor y 0 para alumno: ");
            tipoUsuario = int.Parse(Console.ReadLine());
        } while (tipoUsuario != 0 && tipoUsuario != 1);
        
        using (var context = new AcademiaContext())
        {
            /*
            var usuario = new Usuario()
            {
                IdPlan = idPlan,
                Nombre = nombre,
                Apellido = apellido,
                Edad = DateTime.Now.Year - fechaNac.Year,
                FechaNacimiento = fechaNac,
                Direccion = direccion,
                Tipo = (TiposUsuarios)tipoUsuario,
                Telefono = telefono,
                Legajo = legajo,
                Email = correo,
                Username = nombreUser,
                Password = contra,
                Habilitado = false
            };
            */
            usuario.Tipo = (TiposUsuarios)tipoUsuario;
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            Console.WriteLine($"Usuario creado: ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, " +
                          $"Edad: {usuario.Edad}, Fecha de Nacimiento: {usuario.FechaNacimiento.ToShortDateString()}, " +
                          $"Dirección: {usuario.Direccion}, Tipo: {usuario.Tipo}, Telefono: {usuario.Telefono}, " +
                          $"Legajo: {usuario.Legajo}, Email: {usuario.Email}, Username: {usuario.Username}, " +
                          $"Habilitado: {usuario.Habilitado}");
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
                          $"Edad: {usuario.Edad}, Fecha de Nacimiento: {usuario.FechaNacimiento.ToShortDateString()}, " +
                          $"Dirección: {usuario.Direccion}, Tipo: {usuario.Tipo}, Telefono: {usuario.Telefono}, " +
                          $"Legajo: {usuario.Legajo}, Email: {usuario.Email}, Username: {usuario.Username}, " +
                          $"Habilitado: {usuario.Habilitado}");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado.");
            }
        }
    }

    public static void ActualizarUsuario(int legajo)
    {
        int decision = 10;

        while (decision > 9 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- Nombre" +
            "              \n   2- Apellido" +
            "              \n   3- Fecha de nacimiento" +
            "              \n   4- Dirección" +
            "              \n   5- Teléfono" +
            "              \n   6- Legajo" +
            "              \n   7- Email" +
            "              \n   8- Nombre de usuario" +
            "              \n   9- Contraseña" +
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
                            Console.Write("\nIngrese la nueva fecha de nacimiento (formato: dd/MM/yyyy): ");
                            string fechaInput = Console.ReadLine();
                            if (DateTime.TryParseExact(fechaInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime nuevaFechaNacimiento))
                            {
                                usuario.FechaNacimiento = nuevaFechaNacimiento;
                            }
                            else
                            {
                                Console.WriteLine("El formato de fecha no es válido. Intente nuevamente.");
                            }
                            break;

                        case 4:
                            Console.Write("\nIngrese la nueva dirección: ");
                            usuario.Direccion = Console.ReadLine();
                            break;

                        case 5:
                            Console.Write("\nIngrese el nuevo teléfono: ");
                            usuario.Telefono = Console.ReadLine();
                            break;

                        case 6:
                            Console.Write("\nIngrese la nueva legajo: ");
                            usuario.Legajo = int.Parse(Console.ReadLine());
                            break;

                        case 7:
                            Console.Write("\nIngrese el nuevo correo: ");
                            usuario.Email = Console.ReadLine();
                            break;

                        case 8:
                            Console.Write("\nIngrese el nuevo nombre de usuario: ");
                            usuario.Username = Console.ReadLine();
                            break;

                        case 9:
                            Console.Write("\nIngrese la nueva contraseña: ");
                            usuario.Password = Console.ReadLine();
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Usuario actualizado: ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, " +
                          $"Edad: {usuario.Edad}, Fecha de Nacimiento: {usuario.FechaNacimiento.ToShortDateString()}, " +
                          $"Dirección: {usuario.Direccion}, Tipo: {usuario.Tipo}, Telefono: {usuario.Telefono}, " +
                          $"Legajo: {usuario.Legajo}, Email: {usuario.Email}, Username: {usuario.Username}, " +
                          $"Habilitado: {usuario.Habilitado}");
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
            var usuario = context.Usuarios.FirstOrDefault(u => u.Legajo == legajo);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                Console.WriteLine($"Usuario eliminado: ID: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, " +
                          $"Edad: {usuario.Edad}, Fecha de Nacimiento: {usuario.FechaNacimiento.ToShortDateString()}, " +
                          $"Dirección: {usuario.Direccion}, Tipo: {usuario.Tipo}, Telefono: {usuario.Telefono}, " +
                          $"Legajo: {usuario.Legajo}, Email: {usuario.Email}, Username: {usuario.Username}, " +
                          $"Habilitado: {usuario.Habilitado}");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado.");
            }
        }
    }
}
