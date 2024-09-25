using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Plan_Controller
{
    public static void CrearPlan(/*int idPLan, */int idEspecialidad, string descripcion)
    {
        using (var context = new AcademiaContext())
        {
            var plan = new Plan()
            {
                //IdPlan = id,
                IdEspecialidad = idEspecialidad,
                Descripcion = descripcion
            };

            context.Planes.Add(plan);
            context.SaveChanges();
            Console.WriteLine($"Plan creado: ID: {plan.IdPlan}, Id de especialidad: {plan.IdEspecialidad}, Descripcion: {plan.Descripcion}");
        }
    }

    public static void LeerPlan(int idPlan)
    {
        using (var context = new AcademiaContext())
        {
            var plan = context.Planes.FirstOrDefault(p => p.IdPlan == idPlan);
            if (plan != null)
            {
                Console.WriteLine($"Plan creado: ID: {plan.IdPlan}, Id de especialidad: {plan.IdEspecialidad}, Descripcion: {plan.Descripcion}");
            }
            else
            {
                Console.WriteLine("Plan no encontrado.");
            }
        }
    }

    public static void ActualizarPlan(int idPlan)
    {
        int decision = 9;

        while (decision > 2 || decision < 0)
        {
            Console.WriteLine("\n¿Qué propiedad desea modificar?" +
            "              \n   1- La especialidad" +
            "              \n   2- La descripción" +
            "              \n   0- Salir");
            Console.Write("\nIngrese su decisión: ");
            decision = int.Parse(Console.ReadLine());
        }

        if (decision != 0)
        {
            using (var context = new AcademiaContext())
            {
                var plan = context.Planes.FirstOrDefault(p => p.IdPlan == idPlan);
                if (plan != null)
                {
                    switch (decision)
                    {
                        case 1:     // Modificar esta parte, es imposible que un usuario se acuerde del idEspecialidad.
                            Console.Write("\nIngrese el id de la nueva especialidad: ");
                            plan.IdEspecialidad = int.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nIngrese la nueva descripción: ");
                            plan.Descripcion = Console.ReadLine();
                            break;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Plan creado: ID: {plan.IdPlan}, Id de especialidad: {plan.IdEspecialidad}, Descripcion: {plan.Descripcion}");
                }
                else
                {
                    Console.WriteLine("Plan no encontrado.");
                }
            }
        }
    }

    public static void EliminarPlan(int idPlan)
    {
        using (var context = new AcademiaContext())
        {
            var plan = context.Planes.FirstOrDefault(p => p.IdPlan == idPlan);
            if (plan != null)
            {
                context.Planes.Remove(plan);
                context.SaveChanges();
                Console.WriteLine($"Plan creado: ID: {plan.IdPlan}, Id de especialidad: {plan.IdEspecialidad}, Descripcion: {plan.Descripcion}");
            }
            else
            {
                Console.WriteLine("Plan no encontrado.");
            }
        }
    }
}
