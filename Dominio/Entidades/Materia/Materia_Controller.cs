using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Materia_Controller
{
    public static void CrearMateria(/*int id, */string descripcion, int idPlan, int hs_semanales, int hs_totales)
    {
        using (var context = new AcademiaContext())
        {
            var materia = new Materia()
            {
                //IdMateria = id,
                Descripcion = descripcion,
                IdPlan = idPlan,
                HsSemanales = hs_semanales,
                HsTotales = hs_totales
            };

            context.Materias.Add(materia);
            context.SaveChanges();
            Console.WriteLine($"Materia creada: ID: {materia.IdMateria}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");

        }
    }

    public static void LeerMateria(int idMateria)
    {
        using (var context = new AcademiaContext())
        {
            var materia = context.Materias.FirstOrDefault(m => m.IdMateria == idMateria);
            if (materia != null)
            {
                Console.WriteLine($"Materia creada: ID: {materia.IdMateria}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");
            }
            else
            {
                Console.WriteLine("Materia no encontrado.");
            }
        }
    }

    public static void ActualizarMateria(int idMateria)
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
                var materia = context.Materias.FirstOrDefault(m => m.IdMateria == idMateria);
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
                    Console.WriteLine($"Materia creada: ID: {materia.IdMateria}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");
                }
                else
                {
                    Console.WriteLine("Materia no encontrado.");
                }
            }
        }
    }

    public static void EliminarMateria(int idMateria)
    {
        using (var context = new AcademiaContext())
        {
            var materia = context.Materias.FirstOrDefault(m => m.IdMateria == idMateria);
            if (materia != null)
            {
                context.Materias.Remove(materia);
                context.SaveChanges();
                Console.WriteLine($"Materia creada: ID: {materia.IdMateria}, Descripción: {materia.Descripcion}, " +
                              $"ID Plan: {materia.IdPlan}, Horas Semanales: {materia.HsSemanales}, Horas Totales: {materia.HsTotales}");
            }
            else
            {
                Console.WriteLine("Materia no encontrado.");
            }
        }
    }
}
