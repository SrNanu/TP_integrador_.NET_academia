using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Modulo_Controller
{
    public static void CrearModulo(Modulo modulo)
    {

        using var context = new AcademiaContext();

        context.Modulos.Add(modulo);
        context.SaveChanges();

    }

    public static Modulo? GetOneModulo(int id)
    {
        using var context = new AcademiaContext();

        return context.Modulos.Find(id);

    }

    public static IEnumerable<Modulo> GetAllModulo()
    {
        using var context = new AcademiaContext();

        return context.Modulos.ToList();
    }

    public static void ActualizarModulo(Modulo modulo)
    {
        using var context = new AcademiaContext();

        var moduloToUpdate = context.Modulos.Find(modulo.Id);

        if (moduloToUpdate != null)
        {
            moduloToUpdate.Descripcion = moduloToUpdate.Descripcion;
            moduloToUpdate.Id = modulo.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarModulo(int id)
    {
        using var context = new AcademiaContext();

        var modulo = context.Modulos.Find(id);
        if (modulo != null)
        {
            context.Modulos.Remove(modulo);
            context.SaveChanges();
        }

    }
}
