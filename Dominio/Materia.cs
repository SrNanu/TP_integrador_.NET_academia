using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Materia : EntidadNegocio
{
    [Key]
    public int IdMateria { get; set; }

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
