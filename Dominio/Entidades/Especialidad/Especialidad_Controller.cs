using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Especialidad_Controller
{
    public static void CrearEspecialidad(Especialidad especialidad)
    {

        using var context = new AcademiaContext();

        context.Especialidades.Add(especialidad);
        context.SaveChanges();

    }

    public static Especialidad? GetOneEspecialidad(int id)
    {
        using var context = new AcademiaContext();

        return context.Especialidades.Find(id);

    }

    public static IEnumerable<Especialidad> GetAllEspecialidad()
    {
        using var context = new AcademiaContext();

        return context.Especialidades.ToList();
    }

    public static void ActualizarEspecialidad(Especialidad especialidad)
    {
        using var context = new AcademiaContext();

        var especialidadToUpdate = context.Especialidades.Find(especialidad.Id);

        if (especialidadToUpdate != null)
        {
            especialidadToUpdate.Descripcion = especialidad.Descripcion;
            especialidadToUpdate.Id = especialidad.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarEspecialidad(int id)
    {
        using var context = new AcademiaContext();

        var especialidad = context.Especialidades.Find(id);
        if (especialidad != null)
        {
            context.Especialidades.Remove(especialidad);
            context.SaveChanges();
        }

    }
}
