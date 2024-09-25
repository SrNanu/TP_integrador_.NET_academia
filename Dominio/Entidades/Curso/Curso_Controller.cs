using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Curso_Controller
{
    public static void CrearCurso(/*int id, */int idComision, int idMateria, int cupo, int anioCalendario, string descripcion)
    {
        using (var context = new AcademiaContext())
        {
            var curso = new Curso()
            {
                //IdCurso = id,
                IdComision = idComision,
                IdMateria = idMateria,
                Cupo = cupo,
                AnioCalendario = anioCalendario,
                Descripcion = descripcion
            };

            context.Cursos.Add(curso);
            context.SaveChanges();
            Console.WriteLine($"Curso creado: ID: {curso.IdCurso}, ID Comision: {curso.IdComision}, ID Materia: {curso.IdMateria}, " +
                              $"Cupo: {curso.Cupo}, Año Calendario: {curso.AnioCalendario}, Descripción: {curso.Descripcion}");

        }
    }

    public static void LeerCurso(int idCurso)
    {
        using (var context = new AcademiaContext())
        {
            var curso = context.Cursos.FirstOrDefault(c => c.IdCurso == idCurso);
            if (curso != null)
            {
                Console.WriteLine($"Curso creado: ID: {curso.IdCurso}, ID Comision: {curso.IdComision}, ID Materia: {curso.IdMateria}, " +
                                  $"Cupo: {curso.Cupo}, Año Calendario: {curso.AnioCalendario}, Descripción: {curso.Descripcion}");

            }
            else
            {
                Console.WriteLine("Curso no encontrado.");
            }
        }
    }

    public static void ActualizarCurso(int idCurso)
    {
        int decision = 10;

        while (decision > 5 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- Id de la comisión" +
            "              \n   2- Id de la materia" +
            "              \n   3- Cupo" +
            "              \n   4- Año Calendario" +
            "              \n   5- Descripción" +
            "              \n   0- Salir");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var curso = context.Cursos.FirstOrDefault(c => c.IdCurso == idCurso);
                if (curso != null)
                {
                    switch (decision)
                    {
                        case 1:
                            Console.Write("\nIngrese el nuevo id de la comisión: ");
                            curso.IdComision = int.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nIngrese el nuevo id de la materia: ");
                            curso.IdMateria = int.Parse(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nIngrese el nuevo cupo: ");
                            curso.Cupo = int.Parse(Console.ReadLine());
                            break;

                        case 5:
                            Console.Write("\nIngrese el nuevo año calendario: ");
                            curso.AnioCalendario = int.Parse(Console.ReadLine());
                            break;

                        case 6:
                            Console.Write("\nIngrese la nueva descripción: ");
                            curso.Descripcion = Console.ReadLine();
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Curso creado: ID: {curso.IdCurso}, ID Comision: {curso.IdComision}, ID Materia: {curso.IdMateria}, " +
                                      $"Cupo: {curso.Cupo}, Año Calendario: {curso.AnioCalendario}, Descripción: {curso.Descripcion}");

                }
                else
                {
                    Console.WriteLine("Curso no encontrado.");
                }
            }
        }
    }

    public static void EliminarCurso(int idCurso)
    {
        using (var context = new AcademiaContext())
        {
            var curso = context.Cursos.FirstOrDefault(c => c.IdCurso == idCurso);
            if (curso != null)
            {
                context.Cursos.Remove(curso);
                context.SaveChanges();
                Console.WriteLine($"Curso creado: ID: {curso.IdCurso}, ID Comision: {curso.IdComision}, ID Materia: {curso.IdMateria}, " +
                                  $"Cupo: {curso.Cupo}, Año Calendario: {curso.AnioCalendario}, Descripción: {curso.Descripcion}");

            }
            else
            {
                Console.WriteLine("Curso no encontrado.");
            }
        }
    }
}
