using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AlumnoInscripcion : EntidadNegocio
{
    [ForeignKey("Usuario")]
    public int IdAlumno { get; set; }

    [ForeignKey("Curso")]
    public int IdCurso { get; set; }

    [StringLength(150)]
    public string? Condicion { get; set; } = "Regular";

    public int? Nota { get; set; }

}