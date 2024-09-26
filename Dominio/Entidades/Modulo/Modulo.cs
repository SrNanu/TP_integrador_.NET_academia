using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Modulo : EntidadNegocio
{
    [Required]
    [StringLength(150)]
    public required string Descripcion { get; set; }

}
