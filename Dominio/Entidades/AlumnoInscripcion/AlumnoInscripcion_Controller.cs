﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Dominio.Entidades;
public class AlumnoInscripcion_Controller
{
    public static void CrearAlumnoInscripcion(AlumnoInscripcion alumnoInscripcion)
    {

        using var context = new AcademiaContext();

        // Validaciones por separado
        Validador.ValidarExistenciaCurso(alumnoInscripcion.IdCurso, context);
        Validador.ValidarExistenciaAlumno(alumnoInscripcion.IdAlumno, context);
        Validador.ValidarTextoNoVacio(alumnoInscripcion.Condicion, "Condición");
        Validador.ValidarRangoNota(alumnoInscripcion.Nota);

        context.AlumnoInscripciones.Add(alumnoInscripcion);
        context.SaveChanges();

    }

    public static AlumnoInscripcion? GetOneAlumnoInscripcion(int id)
    {
        using var context = new AcademiaContext();

        return context.AlumnoInscripciones.Find(id);

    }

    public static IEnumerable<AlumnoInscripcion> GetAllAlumnoInscripcion()
    {
        using var context = new AcademiaContext();

        return context.AlumnoInscripciones.ToList();
    }

    public static void ActualizarAlumnoInscripcion(AlumnoInscripcion alumnoInscripcion)
    {
        using var context = new AcademiaContext();

        var alumnoInscripcionToUpdate = context.AlumnoInscripciones.Find(alumnoInscripcion.Id);

        if (alumnoInscripcionToUpdate != null)
        {
            // Validaciones por separado
            Validador.ValidarExistenciaCurso(alumnoInscripcion.IdCurso, context);
            Validador.ValidarExistenciaAlumno(alumnoInscripcion.IdAlumno, context);
            Validador.ValidarTextoNoVacio(alumnoInscripcion.Condicion, "Condición");
            Validador.ValidarRangoNota(alumnoInscripcion.Nota);

            alumnoInscripcionToUpdate.IdCurso = alumnoInscripcion.IdCurso;
            alumnoInscripcionToUpdate.IdAlumno = alumnoInscripcion.IdAlumno;
            alumnoInscripcionToUpdate.Condicion = alumnoInscripcion.Condicion;
            alumnoInscripcionToUpdate.Nota = alumnoInscripcion.Nota;
            alumnoInscripcionToUpdate.Id = alumnoInscripcion.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarAlumnoInscripcion(int id)
    {
        using var context = new AcademiaContext();

        var alumnoInscripcion = context.AlumnoInscripciones.Find(id);
        if (alumnoInscripcion != null)
        {
            context.AlumnoInscripciones.Remove(alumnoInscripcion);
            context.SaveChanges();
        }

    }
}
