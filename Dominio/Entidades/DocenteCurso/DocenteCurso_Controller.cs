using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

public class DocenteCurso_Controller
{
    public static void CrearDocenteCurso(DocenteCurso docenteCurso)
    {

        using var context = new AcademiaContext();

        // Validaciones por separado
        Validador.ValidarExistenciaCurso(docenteCurso.IdCurso, context);
        Validador.ValidarDocenteTipo(docenteCurso.IdDocente, context);

        context.DocenteCursos.Add(docenteCurso);
        context.SaveChanges();

    }

    public static DocenteCurso? GetOneDocenteCurso(int id)
    {
        using var context = new AcademiaContext();

        return context.DocenteCursos.Find(id);

    }

    public static IEnumerable<DocenteCurso> GetAllDocenteCurso()
    {
        using var context = new AcademiaContext();

        return context.DocenteCursos.ToList();
    }

    public static void ActualizarDocenteCurso(DocenteCurso docenteCurso)
    {
        using var context = new AcademiaContext();

        var docenteCursoToUpdate = context.DocenteCursos.Find(docenteCurso.Id);

        if (docenteCursoToUpdate != null)
        {

            // Validaciones por separado
            Validador.ValidarExistenciaCurso(docenteCurso.IdCurso, context);
            Validador.ValidarDocenteTipo(docenteCurso.IdDocente, context);

            docenteCursoToUpdate.IdCurso = docenteCurso.IdCurso;
            docenteCursoToUpdate.IdDocente = docenteCurso.IdDocente;
            docenteCursoToUpdate.Id = docenteCurso.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarDocenteCurso(int id)
    {
        using var context = new AcademiaContext();

        var docenteCurso = context.DocenteCursos.Find(id);
        if (docenteCurso != null)
        {
            context.DocenteCursos.Remove(docenteCurso);
            context.SaveChanges();
        }

    }
}
