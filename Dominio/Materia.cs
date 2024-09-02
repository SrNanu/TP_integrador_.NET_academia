using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Materia : EntidadNegocio
    {
        [Key]
        public int IdMateria { get; set; }

        [Required]
        [StringLength(100)]
        public required string Descripcion { get; set; }

        [Required]
        public required int HsSemanales { get; set; }

        [Required]
        public required int HsTotales { get; set; }
    }
}
