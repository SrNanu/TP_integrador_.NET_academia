using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModuloUsuario : EntidadNegocio
{
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdModuloUsuario
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

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
