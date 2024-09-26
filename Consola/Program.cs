using System;
using System.Linq;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Contracts;

public class Program
{
    public static void Main(string[] args)
    {
        // ** CRUD Usuario **
        var usuario = new Usuario()
        {
            IdPlan = 1,
            Nombre = "Juan Cruz",
            Apellido = "Mondino",
            Edad = DateTime.Now.Year - new DateTime(2000, 10, 23).Year,
            FechaNacimiento = new DateTime(2000, 10, 23),
            Direccion = "Urquiza 123",
            Telefono = "3364592427",
            Legajo = 12345,
            Email = "juan.mondino@example.com",
            Username = "juan.c",
            Password = "contraseñaSegura",
            Habilitado = false
        };
        Usuario_Controller.CrearUsuario(usuario);
        Usuario_Controller.LeerUsuario(12345);
        Usuario_Controller.ActualizarUsuario(12345);
        Usuario_Controller.LeerUsuario(12345);
        // Estará bien referenciado de esta forma? con la clase por delante

    /*
        // ** CRUD Plan **
        Plan_Controller.CrearPlan(1, "Ingeniería en Sistemas");
        Plan_Controller.LeerPlan(1);
        Plan_Controller.ActualizarPlan(1);
        Plan_Controller.LeerPlan(1);


        // ** CRUD ModuloUsuario **
        ModuloUsuario_Controller.CrearModuloUsuario(1, 12345);
        ModuloUsuario_Controller.LeerModuloUsuario(1);
        ModuloUsuario_Controller.ActualizarModuloUsuario(1);
        ModuloUsuario_Controller.LeerModuloUsuario(1);


        // ** CRUD Modulo **
        Modulo_Controller.CrearModulo("Introducción a Programación");
        Modulo_Controller.LeerModulo(1);
        Modulo_Controller.ActualizarModulo(1);
        Modulo_Controller.LeerModulo(1);


        // ** CRUD Materia **
        Materia_Controller.CrearMateria("Programación I", 1, 4, 64);
        Materia_Controller.LeerMateria(1);
        Materia_Controller.ActualizarMateria(1);
        Materia_Controller.LeerMateria(1);


        // ** CRUD Especialidad **
        Especialidad_Controller.CrearEspecialidad("Ingeniería en Sistemas");
        Especialidad_Controller.LeerEspecialidad(1);
        Especialidad_Controller.ActualizarEspecialidad(1);
        Especialidad_Controller.LeerEspecialidad(1);


        // ** CURD DocenteCurso **
        DocenteCurso_Controller.CrearDocenteCurso(1, 1);
        DocenteCurso_Controller.LeerDocenteCurso(1);
        DocenteCurso_Controller.ActualizarDocenteCurso(1);
        DocenteCurso_Controller.LeerDocenteCurso(1);


        // ** CRUD Curso **
        Curso_Controller.CrearCurso(1, 1, 30, 2024, "Programación I - Comisión A");
        Curso_Controller.LeerCurso(1);
        Curso_Controller.ActualizarCurso(1);
        Curso_Controller.LeerCurso(1);


        // ** CRUD Comision **
        Comision_Controller.CrearComision(1, "Comisión A", 2024);
        Comision_Controller.LeerComision(1);
        Comision_Controller.ActualizarComision(1);
        Comision_Controller.LeerComision(1);


        // ** CRUD AlumnoInscripcion **
        AlumnoInscripcion_Controller.CrearAlumnoInscripcion(1, 1, "Regular", 8);
        AlumnoInscripcion_Controller.LeerAlumnoInscripcion(1);
        AlumnoInscripcion_Controller.ActualizarAlumnoInscripcion(1);
        AlumnoInscripcion_Controller.LeerAlumnoInscripcion(1);



        // Agrupo los métodos de eliminar para probar la conección a la base de datos. <- Colocar aquí el punto de interrupción.
        Usuario_Controller.EliminarUsuario(12345);
        Plan_Controller.EliminarPlan(1);
        ModuloUsuario_Controller.EliminarModuloUsuario(1);
        Modulo_Controller.EliminarModulo(1);
        Materia_Controller.EliminarMateria(1);
        Especialidad_Controller.EliminarEspecialidad(1);
        DocenteCurso_Controller.EliminarDocenteCurso(1);
        Curso_Controller.EliminarCurso(1);
        Comision_Controller.EliminarComision(1);
        AlumnoInscripcion_Controller.EliminarAlumnoInscripcion(1);
    */
    }
}