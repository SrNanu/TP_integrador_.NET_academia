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
    }
}
