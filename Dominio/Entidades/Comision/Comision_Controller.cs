using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Comision_Controller
{
    public static void CrearComision(Comision comision)
    {

        using var context = new AcademiaContext();
        // Validaciones por separado
        Validador.ValidarIdPlan(comision.IdPlan, context);
        Validador.ValidarDescripcionComisionUnica(comision.Descripcion, 0, context); // ponemos 0 porque esta creando la comision
        context.Comisiones.Add(comision);
        context.SaveChanges();

    }

    public static Comision? GetOneComision(int id)
    {
        using var context = new AcademiaContext();

        return context.Comisiones.Find(id);

    }

    public static IEnumerable<Comision> GetAllComision()
    {
        using var context = new AcademiaContext();

        return context.Comisiones.ToList();
    }

    public static void ActualizarComision(Comision comision)
    {
        using var context = new AcademiaContext();

        var comisionToUpdate = context.Comisiones.Find(comision.Id);

        if (comisionToUpdate != null)
        {
            // Validaciones por separado
            Validador.ValidarIdPlan(comision.IdPlan, context);
            Validador.ValidarDescripcionComisionUnica(comision.Descripcion, 0, context); // ponemos 0 porque esta creando la comision

            comisionToUpdate.Descripcion = comision.Descripcion;
            comisionToUpdate.IdPlan = comision.IdPlan;
            comisionToUpdate.AnioEspecialidad = comision.AnioEspecialidad;
            comisionToUpdate.Id = comision.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarComision(int id)
    {
        using var context = new AcademiaContext();

        var comision = context.Comisiones.Find(id);
        if (comision != null)
        {
            context.Comisiones.Remove(comision);
            context.SaveChanges();
        }

    }
}
