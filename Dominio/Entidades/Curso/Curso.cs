using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Curso : EntidadNegocio
{
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdCurso
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    [ForeignKey("Comision")]
    public int IdComision { get; set; }

    [ForeignKey("Materia")]
    public int IdMateria { get; set; }

    [Required]
    public required int Cupo { get; set; }

    [Required]
    public required int AnioCalendario { get; set; }

    [Required]
    [StringLength(150)]
    public required string Descripcion { get; set; }
}
