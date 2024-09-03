using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AlumnoInscripcion : EntidadNegocio
    {
        [Key]
        public int IdAlumnoInscripcion { get; set; }

        [ForeignKey("Alumno")]
        public int IdAlumno { get; set; }

        [ForeignKey("Curso")]
        public int IdCurso { get; set; }

        [Required]
        [StringLength(150)]
        public required string Condicion { get; set; }

        [Required]
        public int Nota {  get; set; }

    }
}
