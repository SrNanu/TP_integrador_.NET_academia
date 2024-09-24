using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Plan : EntidadNegocio
{
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdPlan
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    [ForeignKey("Especialidad")]
    public int IdEspecialidad { get; set; }

    [Required]
    [StringLength(100)]
    public required string Descripcion { get; set; }
}
