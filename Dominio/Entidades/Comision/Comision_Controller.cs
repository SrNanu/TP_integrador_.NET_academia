using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Comision_Controller
{
    public static void CrearComision(int idPlan, string descripcion, int anioEspecialidad)
    {
        using (var context = new AcademiaContext())
        {
            var comision = new Comision()
            {
                IdPlan = idPlan,
                Descripcion = descripcion,
                AnioEspecialidad = anioEspecialidad
            };

            context.Comisiones.Add(comision);
            context.SaveChanges();
            Console.WriteLine($"Comisión creada: ID: {comision.Id}, ID Plan: {comision.IdPlan}, " +
                              $"Descripción: {comision.Descripcion}, Año Especialidad: {comision.AnioEspecialidad}");
        }
    }

    public static void LeerComision(int id)
    {
        using (var context = new AcademiaContext())
        {
            var comision = context.Comisiones.FirstOrDefault(c => c.Id == id);
            if (comision != null)
            {
                Console.WriteLine($"Comisión encontrada: ID: {comision.Id}, ID Plan: {comision.IdPlan}, " +
                                  $"Descripción: {comision.Descripcion}, Año Especialidad: {comision.AnioEspecialidad}");

            }
            else
            {
                Console.WriteLine("Comision no encontrado.");
            }
        }
    }

    public static void ActualizarComision(int id)
    {
        int decision = 10;

        while (decision > 3 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- Id del plan" +
            "              \n   2- Descripción" +
            "              \n   3- Año de especialidad" +
            "              \n   0- Salir");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var comision = context.Comisiones.FirstOrDefault(c => c.Id == id);
                if (comision != null)
                {
                    switch (decision)
                    {
                        case 1:
                            Console.Write("\nIngrese el nuevo id del plan: ");
                            comision.IdPlan = int.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nIngrese la nueva descripción: ");
                            comision.Descripcion = Console.ReadLine();
                            break;

                        case 3:
                            Console.Write("\nIngrese el nuevo año de especialidad: ");
                            comision.AnioEspecialidad = int.Parse(Console.ReadLine());
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Comisión actualizada: ID: {comision.Id}, ID Plan: {comision.IdPlan}, " +
                                      $"Descripción: {comision.Descripcion}, Año Especialidad: {comision.AnioEspecialidad}");

                }
                else
                {
                    Console.WriteLine("Comision no encontrado.");
                }
            }
        }
    }

    public static void EliminarComision(int id)
    {
        using (var context = new AcademiaContext())
        {
            var comision = context.Comisiones.FirstOrDefault(c => c.Id == id);
            if (comision != null)
            {
                context.Comisiones.Remove(comision);
                context.SaveChanges();
                Console.WriteLine($"Comisión eliminada: ID: {comision.Id}, ID Plan: {comision.IdPlan}, " +
                                  $"Descripción: {comision.Descripcion}, Año Especialidad: {comision.AnioEspecialidad}");

            }
            else
            {
                Console.WriteLine("Comision no encontrado.");
            }
        }
    }
}
