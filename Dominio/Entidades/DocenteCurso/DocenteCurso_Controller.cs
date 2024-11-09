using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DocenteCurso_Controller
{
    public async Task<IEnumerable<DocenteCurso>> GetDocentesInscripcionesByIdDocente(int idDocente)     //En vez de IEnumerable podria ir List.
    {
        using var context = new AcademiaContext();

        return await context.DocenteCursos.Where(dc => dc.IdDocente == idDocente).ToListAsync();
    }

    public async Task<IEnumerable<DocenteCurso>> GetDocentesDC(int idCurso)     //En vez de IEnumerable podria ir List.
    {
        using var context = new AcademiaContext();

        return await context.DocenteCursos.Where(dc => dc.IdCurso == idCurso).ToListAsync();
    }

    public static void CrearDocenteCurso(DocenteCurso docenteCurso)
    {

        using var context = new AcademiaContext();

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
