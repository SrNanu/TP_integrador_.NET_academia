using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Curso_Controller
{
    public static void CrearCurso(Curso curso)
    {

        using var context = new AcademiaContext();

        context.Cursos.Add(curso);
        context.SaveChanges();

    }

    public static Curso? GetOneCurso(int id)
    {
        using var context = new AcademiaContext();

        return context.Cursos.Find(id);

    }

    public IEnumerable<Curso> GetCursosByIdMateria(int idMateria)     //En vez de IEnumerable podria ir List.
    {
        using var context = new AcademiaContext();

        return context.Cursos.Where(ai => ai.IdMateria == idMateria).ToList();
    }

    public async Task<Curso?> GetOneCursoByIdMateria(int idMateria)
    {
        using var context = new AcademiaContext();
        AlumnoInscripcion_Controller alumnoInscripcionController = new AlumnoInscripcion_Controller();

        var cursosDeMateria = GetCursosByIdMateria(idMateria);

        foreach (var curso in cursosDeMateria)
        {
            var inscripciones = await alumnoInscripcionController.GetAlumnosInscripcionesByIdCurso(curso.Id);
            int cantidadInscriptos = inscripciones.Count();

            if (cantidadInscriptos < curso.Cupo)
            {
                return curso;
            }
        }

        return null;
    }

    public static IEnumerable<Curso> GetAllCurso()
    {
        using var context = new AcademiaContext();

        return context.Cursos.ToList();
    }

    public static void ActualizarCurso(Curso curso)
    {
        using var context = new AcademiaContext();

        var cursoToUpdate = context.Cursos.Find(curso.Id);

        if (cursoToUpdate != null)
        {
            cursoToUpdate.IdMateria = curso.IdMateria;
            cursoToUpdate.IdComision = curso.IdComision;
            cursoToUpdate.AnioCalendario = curso.AnioCalendario;
            cursoToUpdate.Descripcion = curso.Descripcion;
            cursoToUpdate.Cupo = curso.Cupo;
            cursoToUpdate.Id = curso.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarCurso(int id)
    {
        using var context = new AcademiaContext();

        var curso = context.Cursos.Find(id);
        if (curso != null)
        {
            context.Cursos.Remove(curso);
            context.SaveChanges();
        }

    }
}
