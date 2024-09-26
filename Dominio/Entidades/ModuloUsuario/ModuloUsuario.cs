using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModuloUsuario : EntidadNegocio
{
    [ForeignKey("Modulo")]
    public int IdModulo { get; set; }

    [ForeignKey("Usuario")]
    public int IdUsuario { get; set; }

    [Required]
    public required bool PermiteAlta { get; set; }

    [Required]
    public required bool PermiteBaja { get; set; }

    [Required]
    public required bool PermiteConsulta { get; set; }

    [Required]
    public required bool PermiteModificacion { get; set; }
}
