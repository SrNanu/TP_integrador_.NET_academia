using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Materia : EntidadNegocio
{
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdMateria
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    [Required]
    [StringLength(100)]
    public required string Descripcion { get; set; }

    [ForeignKey("Plan")]
    public int IdPlan { get; set; }

    [Required]
    public required int HsSemanales { get; set; }

    [Required]
    public required int HsTotales { get; set; }
}
