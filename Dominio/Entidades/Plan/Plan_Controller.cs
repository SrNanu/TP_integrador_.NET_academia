using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Plan_Controller
{
    public static void CrearPlan(Plan plan)
    {

        using var context = new AcademiaContext();

        context.Planes.Add(plan);
        context.SaveChanges();

    }

    public static Plan? GetOnePlan(int id)
    {
        using var context = new AcademiaContext();

        return context.Planes.Find(id);

    }

    public static IEnumerable<Plan> GetAllPlan()
    {
        using var context = new AcademiaContext();

        return context.Planes.ToList();
    }

    public static void ActualizarPlan(Plan plan)
    {
        using var context = new AcademiaContext();

        var planToUpdate = context.Planes.Find(plan.Id);

        if (planToUpdate != null)
        {
            planToUpdate.IdEspecialidad = plan.IdEspecialidad;
            planToUpdate.Descripcion = plan.Descripcion;
            planToUpdate.Id = plan.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarPlan(int id)
    {
        using var context = new AcademiaContext();

        var plan = context.Planes.Find(id);
        if (plan != null)
        {
            context.Planes.Remove(plan);
            context.SaveChanges();
        }

    }
}
