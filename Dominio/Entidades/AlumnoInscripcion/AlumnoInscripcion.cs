using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AlumnoInscripcion : EntidadNegocio
{
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdAlumnoInscripcion
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    [ForeignKey("Alumno")]
    public int IdAlumno { get; set; }

    [ForeignKey("Curso")]
    public int IdCurso { get; set; }

    [Required]
    [StringLength(150)]
    public required string Condicion { get; set; }

    [Required]
    public int Nota { get; set; }

}