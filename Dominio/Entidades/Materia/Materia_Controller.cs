using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Materia_Controller
{
    public static void CrearMateria(string descripcion, int idPlan, int hs_semanales, int hs_totales)
    {
        using (var context = new AcademiaContext())
        {
            var materia = new Materia()
            {
                Descripcion = descripcion,
                IdPlan = idPlan,
                HsSemanales = hs_semanales,
                HsTotales = hs_totales
            };

            context.Materias.Add(materia);
            context.SaveChanges();
            Console.WriteLine($"Materia creada: ID: {materia.Id}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");

        }
    }

    public static void LeerMateria(int id)
    {
        using (var context = new AcademiaContext())
        {
            var materia = context.Materias.FirstOrDefault(m => m.Id == id);
            if (materia != null)
            {
                Console.WriteLine($"Materia encontrada: ID: {materia.Id}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");
            }
            else
            {
                Console.WriteLine("Materia no encontrado.");
            }
        }
    }

    public static void ActualizarMateria(int id)
    {
        int decision = 10;

        while (decision > 4 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- Descripción" +
            "              \n   2- Id del plan" +
            "              \n   3- La cantidad de horas semanales" +
            "              \n   4- La cantidad de horas totales" +
            "              \n   0- Salir");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var materia = context.Materias.FirstOrDefault(m => m.Id == id);
                if (materia != null)
                {
                    switch (decision)
                    {
                        case 1:
                            Console.Write("\nIngrese la nueva descripción: ");
                            materia.Descripcion = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("\nIngrese el nuevo Id del plan: ");
                            materia.IdPlan = int.Parse(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nIngrese la nueva cantidad de horas semanales: ");
                            materia.HsSemanales = int.Parse(Console.ReadLine());
                            break;

                        case 4:
                            Console.Write("\nIngrese la nueva cantidad de horas totales: ");
                            materia.HsTotales = int.Parse(Console.ReadLine());
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Materia actualizada: ID: {materia.Id}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");
                }
                else
                {
                    Console.WriteLine("Materia no encontrado.");
                }
            }
        }
    }

    public static void EliminarMateria(int id)
    {
        using (var context = new AcademiaContext())
        {
            var materia = context.Materias.FirstOrDefault(m => m.Id == id);
            if (materia != null)
            {
                context.Materias.Remove(materia);
                context.SaveChanges();
                Console.WriteLine($"Materia eliminada: ID: {materia.Id}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");
            }
            else
            {
                Console.WriteLine("Materia no encontrado.");
            }
        }
    }
}
