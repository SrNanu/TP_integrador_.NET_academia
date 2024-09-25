using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ModuloUsuario_Controller
{
    public static void CrearModuloUsuario(/*int id, */int idModulo, int idUsuario)
    {
        using (var context = new AcademiaContext())
        {
            var ModuloUsuario = new ModuloUsuario()
            {
                //IdModuloUsuario = id,
                IdModulo = idModulo,
                IdUsuario = idUsuario,
                PermiteAlta = false,
                PermiteBaja = false,
                PermiteConsulta = false,
                PermiteModificacion = false
            };

            context.ModuloUsuarios.Add(ModuloUsuario);
            context.SaveChanges();
            Console.WriteLine($"ModuloUsuario creado: ID Módulo Usuario: {ModuloUsuario.IdModuloUsuario}, ID Módulo: {ModuloUsuario.IdModulo}, " +
                              $"ID Usuario: {ModuloUsuario.IdUsuario}, Permite Alta: {ModuloUsuario.PermiteAlta}, Permite Baja: {ModuloUsuario.PermiteBaja}, " +
                              $"Permite Consulta: {ModuloUsuario.PermiteConsulta}, Permite Modificación: {ModuloUsuario.PermiteModificacion}");

        }
    }

    public static void LeerModuloUsuario(int idModuloUsuario)
    {
        using (var context = new AcademiaContext())
        {
            var ModuloUsuario = context.ModuloUsuarios.FirstOrDefault(mu => mu.IdModuloUsuario == idModuloUsuario);
            if (ModuloUsuario != null)
            {
                Console.WriteLine($"ModuloUsuario creado: ID Módulo Usuario: {ModuloUsuario.IdModuloUsuario}, ID Módulo: {ModuloUsuario.IdModulo}, " +
                                  $"ID Usuario: {ModuloUsuario.IdUsuario}, Permite Alta: {ModuloUsuario.PermiteAlta}, Permite Baja: {ModuloUsuario.PermiteBaja}, " +
                                  $"Permite Consulta: {ModuloUsuario.PermiteConsulta}, Permite Modificación: {ModuloUsuario.PermiteModificacion}");
            }
            else
            {
                Console.WriteLine("ModuloUsuario no encontrado.");
            }
        }
    }

    public static void ActualizarModuloUsuario(int idModuloUsuario)
    {
        int decision = 9;

        while (decision > 6 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- ID Módulo" +
            "              \n   2- ID Usuario" +
            "              \n   3- Permite Alta" +
            "              \n   4- Permite Baja" +
            "              \n   5- Permite Consulta" +
            "              \n   6- Permite Modificación");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var ModuloUsuario = context.ModuloUsuarios.FirstOrDefault(mu => mu.IdModuloUsuario == idModuloUsuario);
                if (ModuloUsuario != null)
                {
                    switch (decision)
                    {
                        case 1:
                            Console.Write("\nIngrese el nuevo ID Módulo: ");
                            ModuloUsuario.IdModulo = int.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nIngrese el nuevo ID Usuario: ");
                            ModuloUsuario.IdUsuario = int.Parse(Console.ReadLine());
                            break;

                        case 3:
                            int decision1;
                            do
                            {
                                Console.Write("\nIngrese 1 para permitir el alta y 0 para no hacerlo: ");
                                decision1 = int.Parse(Console.ReadLine());
                            } while (decision1 != 0 || decision1 != 1);

                            if (decision1 == 1)
                            {
                                ModuloUsuario.PermiteAlta = true;
                            }
                            else if (decision1 == 0)
                            {
                                ModuloUsuario.PermiteAlta = false;
                            }
                            break;

                        case 4:
                            int desicion2;
                            do
                            {
                                Console.Write("\nIngrese 1 para permitir la baja y 0 para no hacerlo: ");
                                desicion2 = int.Parse(Console.ReadLine());
                            } while (desicion2 != 0 || desicion2 != 1);

                            if (desicion2 == 1)
                            {
                                ModuloUsuario.PermiteBaja = true;
                            }
                            else if (desicion2 == 0)
                            {
                                ModuloUsuario.PermiteBaja = false;
                            }
                            break;

                        case 5:
                            int desicion3;
                            do
                            {
                                Console.Write("\nIngrese 1 para permitir la consulta y 0 para no hacerlo: ");
                                desicion3 = int.Parse(Console.ReadLine());
                            } while (desicion3 != 0 || desicion3 != 1);

                            if (desicion3 == 1)
                            {
                                ModuloUsuario.PermiteConsulta = true;
                            }
                            else if (desicion3 == 0)
                            {
                                ModuloUsuario.PermiteConsulta = false;
                            }
                            break;

                        case 6:
                            int desicion4;
                            do
                            {
                                Console.Write("\nIngrese 1 para permitir la modificación y 0 para no hacerlo: ");
                                desicion4 = int.Parse(Console.ReadLine());
                            } while (desicion4 != 0 || desicion4 != 1);

                            if (desicion4 == 1)
                            {
                                ModuloUsuario.PermiteModificacion = true;
                            }
                            else if (desicion4 == 0)
                            {
                                ModuloUsuario.PermiteModificacion = false;
                            }
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"ModuloUsuario creado: ID Módulo Usuario: {ModuloUsuario.IdModuloUsuario}, ID Módulo: {ModuloUsuario.IdModulo}, " +
                                      $"ID Usuario: {ModuloUsuario.IdUsuario}, Permite Alta: {ModuloUsuario.PermiteAlta}, Permite Baja: {ModuloUsuario.PermiteBaja}, " +
                                      $"Permite Consulta: {ModuloUsuario.PermiteConsulta}, Permite Modificación: {ModuloUsuario.PermiteModificacion}");
                }
                else
                {
                    Console.WriteLine("ModuloUsuario no encontrado.");
                }
            }
        }
    }

    public static void EliminarModuloUsuario(int idModuloUsuario)
    {
        using (var context = new AcademiaContext())
        {
            var ModuloUsuario = context.ModuloUsuarios.FirstOrDefault(mu => mu.IdModuloUsuario == idModuloUsuario);
            if (ModuloUsuario != null)
            {
                context.ModuloUsuarios.Remove(ModuloUsuario);
                context.SaveChanges();
                Console.WriteLine($"ModuloUsuario creado: ID Módulo Usuario: {ModuloUsuario.IdModuloUsuario}, ID Módulo: {ModuloUsuario.IdModulo}, " +
                                  $"ID Usuario: {ModuloUsuario.IdUsuario}, Permite Alta: {ModuloUsuario.PermiteAlta}, Permite Baja: {ModuloUsuario.PermiteBaja}, " +
                                  $"Permite Consulta: {ModuloUsuario.PermiteConsulta}, Permite Modificación: {ModuloUsuario.PermiteModificacion}");
            }
            else
            {
                Console.WriteLine("ModuloUsuario no encontrado.");
            }
        }
    }

}
