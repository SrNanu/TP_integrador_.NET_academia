using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DocenteCurso_Controller
{
    public static void CrearDocenteCurso(int idCurso, int idDocente)
    {
        int tipoCargo;
        do
        {
            Console.Write("\nIngrese el tipo de usuario 1 para profesor de práctica y 0 para profesor de teoría: ");
            tipoCargo = int.Parse(Console.ReadLine());
        } while (tipoCargo != 0 && tipoCargo != 1);

        using (var context = new AcademiaContext())
        {
            var docenteCurso = new DocenteCurso()
            {
                IdCurso = idCurso,
                IdDocente = idDocente,
                Cargo = (TiposCargos)tipoCargo
            };

            context.DocenteCursos.Add(docenteCurso);
            context.SaveChanges();
            Console.WriteLine($"DocenteCurso creado: ID: {docenteCurso.Id}, ID Curso: {docenteCurso.IdCurso}, " +
                              $"ID Docente: {docenteCurso.IdDocente}, Cargo: {docenteCurso.Cargo}");

        }
    }

    public static void LeerDocenteCurso(int id)
    {
        using (var context = new AcademiaContext())
        {
            var docenteCurso = context.DocenteCursos.FirstOrDefault(dc => dc.Id == id);
            if (docenteCurso != null)
            {
                Console.WriteLine($"DocenteCurso leido: ID: {docenteCurso.Id}, ID Curso: {docenteCurso.IdCurso}, " +
                                  $"ID Docente: {docenteCurso.IdDocente}, Cargo: {docenteCurso.Cargo}");

            }
            else
            {
                Console.WriteLine("DocenteCurso no encontrado.");
            }
        }
    }

    public static void ActualizarDocenteCurso(int id)
    {
        int decision = 10;

        while (decision > 3 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- Id del curso" +
            "              \n   2- Id del docente" +
            "              \n   3- Cargo" +
            "              \n   0- Salir");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var docenteCurso = context.DocenteCursos.FirstOrDefault(dc => dc.Id == id);
                if (docenteCurso != null)
                {
                    switch (decision)
                    {
                        case 1:
                            Console.Write("\nIngrese el nuevo nombre: ");
                            docenteCurso.IdCurso = int.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nIngrese el nuevo apellido: ");
                            docenteCurso.IdDocente = int.Parse(Console.ReadLine());
                            break;

                        case 3:
                            int decisionCargo;
                            do
                            {
                                Console.Write("\nIngrese 0 para indicar que el profesor es de teoría y 1 para indicar que el profesor es de práctica: ");
                                decisionCargo = int.Parse(Console.ReadLine());
                            } while (!(decisionCargo == 0 && decisionCargo == 1));

                            if (decisionCargo == 1)
                            {
                                docenteCurso.Cargo = TiposCargos.ProfesorTeoria;
                            }
                            else if (decisionCargo == 0)
                            {
                                docenteCurso.Cargo = TiposCargos.ProfesorPractica;
                            }
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"DocenteCurso actualizado: ID: {docenteCurso.Id}, ID Curso: {docenteCurso.IdCurso}, " +
                                      $"ID Docente: {docenteCurso.IdDocente}, Cargo: {docenteCurso.Cargo}");

                }
                else
                {
                    Console.WriteLine("DocenteCurso no encontrado.");
                }
            }
        }
    }

    public static void EliminarDocenteCurso(int id)
    {
        using (var context = new AcademiaContext())
        {
            var docenteCurso = context.DocenteCursos.FirstOrDefault(dc => dc.Id == id);
            if (docenteCurso != null)
            {
                context.DocenteCursos.Remove(docenteCurso);
                context.SaveChanges();
                Console.WriteLine($"DocenteCurso eliminado: ID: {docenteCurso.Id}, ID Curso: {docenteCurso.IdCurso}, " +
                                  $"ID Docente: {docenteCurso.IdDocente}, Cargo: {docenteCurso.Cargo}");

            }
            else
            {
                Console.WriteLine("DocenteCurso no encontrado.");
            }
        }
    }
}
