using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona : BusinessEntity
    {
        //Se coloca "required adelante de cada atributo para que no salte error, se lo deja hasta que se complete el constructor."

        [Key]
        public int IdPersona { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public required string Apellido { get; set; }

        [Required]
        public float? Edad { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(200)]
        public required string Direccion { get; set; }

        [Required]
        [StringLength(100)]
        public required int TipoPersona { get; set; }

        [StringLength(100)]
        public string? Telefono { get; set; }

        [Required]
        public required int Legajo { get; set; }
    }
}
