using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Usuario : EntidadNegocio
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(150)]
        public required string Email { get; set; }

        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        [StringLength(10)]
        public required string Password { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }

    //SIN VALIDACIONES (System.ComponentModel.DataAnnotsations)
    /*
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
    */
}
