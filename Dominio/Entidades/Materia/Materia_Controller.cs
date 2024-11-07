using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

public class Materia_Controller
{
    public static void CrearMateria(Materia materia)
    {

        using var context = new AcademiaContext();

        // Validar campos
        Validador.ValidarTextoNoVacio(materia.Descripcion, "Descripcion");
        Validador.ValidarIdPlan(materia.IdPlan, context);
        Validador.ValidarInt(materia.HsSemanales, "Horas Semanales");
        Validador.ValidarInt(materia.HsTotales, "Horas Totales");
        Validador.ValidarDescripcionMateriaUnica(materia.Descripcion, context); //en este no mandamos id porque esta creando la materia

        context.Materias.Add(materia);
        context.SaveChanges();

    }

    public static Materia? GetOneMateria(int id)
    {
        using var context = new AcademiaContext();

        return context.Materias.Find(id);

    }

    public static IEnumerable<Materia> GetAllMateria()
    {
        using var context = new AcademiaContext();

        return context.Materias.ToList();
    }

    public static void ActualizarMateria(Materia materia)
    {
        using var context = new AcademiaContext();

        var materiaToUpdate = context.Materias.Find(materia.Id);

        

        if (materiaToUpdate != null)
        {

            // Validar campos
            // Validar campos
            Validador.ValidarTextoNoVacio(materia.Descripcion, "Descripcion");
            Validador.ValidarIdPlan(materia.IdPlan, context);
            Validador.ValidarInt(materia.HsSemanales, "Horas Semanales");
            Validador.ValidarInt(materia.HsTotales, "Horas Totales");
            Validador.ValidarDescripcionMateriaUnica(materia.Descripcion, context, materia.Id); //en este mandamos el id para que no se valide contra si mismo

            materiaToUpdate.Descripcion = materia.Descripcion;
            materiaToUpdate.HsSemanales = materia.HsSemanales;
            materiaToUpdate.HsTotales = materia.HsTotales;
            materiaToUpdate.IdPlan = materia.IdPlan;
            materiaToUpdate.Id = materia.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarMateria(int id)
    {
        using var context = new AcademiaContext();

        var materia = context.Materias.Find(id);
        if (materia != null)
        {
            context.Materias.Remove(materia);
            context.SaveChanges();
        }

    }
}
