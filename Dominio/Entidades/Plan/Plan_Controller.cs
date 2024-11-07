using Dominio.Entidades;
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

        // Validaciones por separado
        Validador.ValidarTextoNoVacio(plan.Descripcion, "Descripción");
        Validador.ValidarLongitudMaxima(plan.Descripcion, 100, "Descripción");
        Validador.ValidarExistenciaEspecialidad(plan.IdEspecialidad, context);
        Validador.ValidarDescripcionPlanUnica(plan.Descripcion, 0, context); // ponemos 0 porque esta creando el plan

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
            // Validaciones por separado
            Validador.ValidarTextoNoVacio(plan.Descripcion, "Descripción");
            Validador.ValidarLongitudMaxima(plan.Descripcion, 100, "Descripción");

            Validador.ValidarExistenciaEspecialidad(plan.IdEspecialidad, context);
            Validador.ValidarDescripcionPlanUnica(plan.Descripcion, plan.Id, context); // en este ponemos el id asi no se valida contra si mismo

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
