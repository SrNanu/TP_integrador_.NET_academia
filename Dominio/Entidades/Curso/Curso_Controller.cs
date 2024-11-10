using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
public class Curso_Controller
{
    public static void CrearCurso(Curso curso)
    {

        using var context = new AcademiaContext();

        // Validaciones
        Validador.ValidarExistenciaComision(curso.IdComision, context);
        Validador.ValidarExistenciaMateria(curso.IdMateria, context);
        Validador.ValidarCupo(curso.Cupo);
        Validador.ValidarDescripcionCursoUnica(curso.Descripcion, 0, context); //se manda 0 porque se esta creando

        context.Cursos.Add(curso);
        context.SaveChanges();

    }

    public static Curso? GetOneCurso(int id)
    {
        using var context = new AcademiaContext();

        return context.Cursos.Find(id);

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

            // Validaciones
            Validador.ValidarExistenciaComision(curso.IdComision, context);
            Validador.ValidarExistenciaMateria(curso.IdMateria, context);
            Validador.ValidarCupo(curso.Cupo);
            Validador.ValidarDescripcionCursoUnica(curso.Descripcion, curso.Id, context);

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
