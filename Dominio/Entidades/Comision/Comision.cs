using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Comision : EntidadNegocio
{
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdComision
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    [ForeignKey("Plan")]
    public int IdPlan { get; set; }

    [Required]
    [StringLength(150)]
    public required string Descripcion { get; set; }

    [Required]
    public required int AnioEspecialidad { get; set; }
}
