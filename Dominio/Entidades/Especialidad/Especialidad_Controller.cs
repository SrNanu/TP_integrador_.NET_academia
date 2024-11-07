using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
public class Especialidad_Controller
{
    public static void CrearEspecialidad(Especialidad especialidad)
    {

        using var context = new AcademiaContext();

        // Validar campos
        Validador.ValidarTextoNoVacio(especialidad.Descripcion, "Descripcion");
        Validador.ValidarDescripcionEspecialidadUnica(especialidad.Descripcion, context); //en este no mandamos id porque esta creando la especialidad

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
            // Validar campos
            Validador.ValidarTextoNoVacio(especialidad.Descripcion, "Descripcion");
            Validador.ValidarDescripcionEspecialidadUnica(especialidad.Descripcion, context, especialidad.Id); //en este mandamos id para que no se valide contra si mismo

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
