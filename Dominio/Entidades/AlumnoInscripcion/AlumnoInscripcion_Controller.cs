using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AlumnoInscripcion_Controller
{
    public static void CrearAlumnoInscripcion(/*int id, */int idAlumno, int idCurso, string condicion, int nota)
    {
        using (var context = new AcademiaContext())
        {
            var alumnoInscripcion = new AlumnoInscripcion()
            {
                //IdAlumnoInscripcion = id,
                IdAlumno = idAlumno,
                IdCurso = idCurso,
                Condicion = condicion,
                Nota = nota
            };

            context.AlumnoInscripciones.Add(alumnoInscripcion);
            context.SaveChanges();
            Console.WriteLine($"AlumnoInscripción creado: ID: {alumnoInscripcion.IdAlumnoInscripcion}, ID Alumno: {alumnoInscripcion.IdAlumno}, " +
                              $"ID Curso: {alumnoInscripcion.IdCurso}, Condición: {alumnoInscripcion.Condicion}, Nota: {alumnoInscripcion.Nota}");

        }
    }

    public static void LeerAlumnoInscripcion(int idAlumnoInscripcion)
    {
        using (var context = new AcademiaContext())
        {
            var alumnoInscripcion = context.AlumnoInscripciones.FirstOrDefault(ai => ai.IdAlumnoInscripcion == idAlumnoInscripcion);
            if (alumnoInscripcion != null)
            {
                Console.WriteLine($"AlumnoInscripción creado: ID: {alumnoInscripcion.IdAlumnoInscripcion}, ID Alumno: {alumnoInscripcion.IdAlumno}, " +
                                  $"ID Curso: {alumnoInscripcion.IdCurso}, Condición: {alumnoInscripcion.Condicion}, Nota: {alumnoInscripcion.Nota}");

            }
            else
            {
                Console.WriteLine("AlumnoInscripcion no encontrado.");
            }
        }
    }

    public static void ActualizarAlumnoInscripcion(int idAlumnoInscripcion)
    {
        int decision = 10;

        while (decision > 4 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- Id del alumno" +
            "              \n   2- Id del curso" +
            "              \n   3- Condición" +
            "              \n   4- Nota" +
            "              \n   0- Salir");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var alumnoInscripcion = context.AlumnoInscripciones.FirstOrDefault(ai => ai.IdAlumnoInscripcion == idAlumnoInscripcion);
                if (alumnoInscripcion != null)
                {
                    switch (decision)
                    {
                        case 1:
                            Console.Write("\nIngrese el nuevo id del alumno: ");
                            alumnoInscripcion.IdAlumno = int.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nIngrese el nuevo id del curso: ");
                            alumnoInscripcion.IdCurso = int.Parse(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nIngrese la nueva condición: ");
                            alumnoInscripcion.Condicion = Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("\nIngrese la nueva nota: ");
                            alumnoInscripcion.Nota = int.Parse(Console.ReadLine());
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"AlumnoInscripción creado: ID: {alumnoInscripcion.IdAlumnoInscripcion}, ID Alumno: {alumnoInscripcion.IdAlumno}, " +
                                      $"ID Curso: {alumnoInscripcion.IdCurso}, Condición: {alumnoInscripcion.Condicion}, Nota: {alumnoInscripcion.Nota}");

                }
                else
                {
                    Console.WriteLine("AlumnoInscripcion no encontrado.");
                }
            }
        }
    }

    public static void EliminarAlumnoInscripcion(int idAlumnoInscripcion)
    {
        using (var context = new AcademiaContext())
        {
            var alumnoInscripcion = context.AlumnoInscripciones.FirstOrDefault(ai => ai.IdAlumnoInscripcion == idAlumnoInscripcion);
            if (alumnoInscripcion != null)
            {
                context.AlumnoInscripciones.Remove(alumnoInscripcion);
                context.SaveChanges();
                Console.WriteLine($"AlumnoInscripción creado: ID: {alumnoInscripcion.IdAlumnoInscripcion}, ID Alumno: {alumnoInscripcion.IdAlumno}, " +
                                  $"ID Curso: {alumnoInscripcion.IdCurso}, Condición: {alumnoInscripcion.Condicion}, Nota: {alumnoInscripcion.Nota}");

            }
            else
            {
                Console.WriteLine("AlumnoInscripcion no encontrado.");
            }
        }
    }
}
