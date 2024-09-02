using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Curso : EntidadNegocio
    {
        [Key]
        public int IdCurso { get; set; }

        [Required]
        public required int Cupo { get; set; }

        [Required]
        public required int AnioCalendario { get; set; }

        [Required]
        [StringLength(150)]
        public required string Descripcion { get; set; }
    }
}
