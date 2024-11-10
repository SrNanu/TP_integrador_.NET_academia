using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Materia_Controller
{
    public static void CrearMateria(Materia materia)
    {

        using var context = new AcademiaContext();

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
