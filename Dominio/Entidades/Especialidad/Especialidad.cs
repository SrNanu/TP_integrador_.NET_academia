using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Especialidad : EntidadNegocio
{
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdEspecialidad
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    [Required]
    [StringLength(150)]
    public required string Descripcion { get; set; }
}

