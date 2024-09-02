using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Comision : EntidadNegocio
    {
        [Key]
        public int IdComision { get; set; }

        [Required]
        [StringLength(150)]
        public required string Descripcion { get; set; }

        [Required]
        public required int AnioEspecialidad { get; set; }
    }
}
