using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Validador
    {
        // Método para validar si un campo de texto no está vacío o nulo
        public static void ValidarTextoNoVacio(string campo, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(campo))
            {
                throw new ArgumentException($"{nombreCampo} no puede estar vacío.");
            }
        }

        // Método para validar si un correo es único en la base de datos
        public static void ValidarEmailUnico(string email, AcademiaContext context)
        {
            if (context.Usuarios.Any(u => u.Email == email))
            {
                throw new ArgumentException("El correo electrónico ya está en uso.");
            }
        }

        // Método para validar si el legajo es único en la base de datos
        public static void ValidarLegajoUnico(int legajo, AcademiaContext context)
        {
            if (context.Usuarios.Any(u => u.Legajo == legajo))
            {
                throw new ArgumentException("El legajo ya está en uso.");
            }
        }

        // Método para validar si un username es único
        public static void ValidarUsernameUnico(string username, AcademiaContext context)
        {
            if (context.Usuarios.Any(u => u.Username == username))
            {
                throw new ArgumentException("El nombre de usuario ya está en uso.");
            }
        }

        // Validación para longitud máxima de un campo
        public static void ValidarLongitudMaxima(string campo, int longitudMaxima, string nombreCampo)
        {
            if (campo.Length > longitudMaxima)
                throw new ArgumentException($"El campo {nombreCampo} no puede exceder los {longitudMaxima} caracteres.");
        }

        // Validación para existencia de especialidad
        public static void ValidarExistenciaEspecialidad(int idEspecialidad, AcademiaContext contexto)
        {
            if (!contexto.Especialidades.Any(e => e.Id == idEspecialidad))
                throw new ArgumentException("La especialidad seleccionada no existe.");
        }

        // Validación para la unicidad de la descripción del plan
        public static void ValidarDescripcionPlanUnica(string descripcion, int idPlan, AcademiaContext contexto)
        {
            if (contexto.Planes.Any(p => p.Descripcion == descripcion && p.Id != idPlan))
                throw new ArgumentException("Ya existe un plan con la misma descripción.");
        }

        // Validar que la descripción de la materia sea única
        public static void ValidarDescripcionMateriaUnica(string descripcion, AcademiaContext context, int? idMateria = null)
        {
            if (context.Materias.Any(m => m.Descripcion == descripcion && m.Id != idMateria))
            {
                throw new ArgumentException("Ya existe una materia con esa descripción.");
            }
        }

        // Validar que lasque int sea mayor a 0
        public static void ValidarInt(int campo, string nombreCampo)
        {
            if (campo <= 0)
            {
                throw new ArgumentException("Las horas totales deben ser mayores que 0.");
            }
        }

        public static void ValidarIdPlan(int idPlan, AcademiaContext context)
        {
            if (!context.Planes.Any(p => p.Id == idPlan))
            {
                throw new ArgumentException("El Plan seleccionado no existe.");
            }
        }

        // Validar que la descripción de la especialidad sea única
        public static void ValidarDescripcionEspecialidadUnica(string descripcion, AcademiaContext context, int? idEspecialidad = null)
        {
            if (context.Especialidades.Any(m => m.Descripcion == descripcion && m.Id != idEspecialidad))
            {
                throw new ArgumentException("Ya existe una Especialidad con esa descripción.");
            }
        }

        public static void ValidarDocenteTipo(int idDocente, AcademiaContext contexto)
        {
            var usuario = contexto.Usuarios.FirstOrDefault(u => u.Id == idDocente);

            if (usuario == null)
            {
                throw new ArgumentException("El usuario especificado no existe.");
            }

            if (usuario.Tipo != TiposUsuarios.Profesor)
            {
                throw new ArgumentException("El usuario especificado no es de tipo Docente.");
            }
        }

        public static void ValidarExistenciaCurso(int idCurso, AcademiaContext contexto)
        {
            if (!contexto.Cursos.Any(c => c.Id == idCurso))
            {
                throw new ArgumentException("El curso especificado no existe.");
            }
        }

        // Validar que la comisión exista en la base de datos
        public static void ValidarExistenciaComision(int idComision, AcademiaContext contexto)
        {
            if (!contexto.Comisiones.Any(c => c.Id == idComision))
            {
                throw new ArgumentException("La comisión especificada no existe.");
            }
        }

        // Validar que la materia exista en la base de datos
        public static void ValidarExistenciaMateria(int idMateria, AcademiaContext contexto)
        {
            if (!contexto.Materias.Any(m => m.Id == idMateria))
            {
                throw new ArgumentException("La materia especificada no existe.");
            }
        }

        // Validar que el cupo sea un número positivo y dentro de un rango lógico (1 y 100)
        public static void ValidarCupo(int cupo)
        {
            if (cupo <= 0 || cupo > 100)
            {
                throw new ArgumentException("El cupo debe ser un número positivo entre 1 y 100.");
            }
        }

        // Validar que la descripción del curso no esté vacía y sea única
        public static void ValidarDescripcionCursoUnica(string descripcion, int idCurso, AcademiaContext contexto)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descripción no puede estar vacía.");
            }

            if (contexto.Cursos.Any(c => c.Descripcion == descripcion && c.Id != idCurso))
            {
                throw new ArgumentException("Ya existe un curso con la misma descripción.");
            }

        }

        // Validación que la descripción de la comisión sea única
        public static void ValidarDescripcionComisionUnica(string descripcion, int idComision, AcademiaContext contexto)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descripción no puede estar vacía.");
            }

            if (contexto.Comisiones.Any(c => c.Descripcion == descripcion ))
            {
                throw new ArgumentException("Ya existe una comisión con la misma descripción.");
            }
        }

        // Validación para existencia de Alumno
        public static void ValidarExistenciaAlumno(int idAlumno, AcademiaContext contexto)
        {
            if (!contexto.Usuarios.Any(u => u.Id == idAlumno && u.Tipo == TiposUsuarios.Alumno))
            {
                throw new ArgumentException("El alumno seleccionado no existe o no es un tipo válido de usuario.");
            }
        }

        // Validación del rango de la Nota
        public static void ValidarRangoNota(int nota)
        {
            if (nota < 0 || nota > 10)
            {
                throw new ArgumentException("La nota debe estar entre 0 y 10.");
            }
        }
    }
}
