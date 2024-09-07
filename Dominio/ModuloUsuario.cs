using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModuloUsuario : EntidadNegocio
    {
        [Key]
        public int IdModuloUsuario { get; set; }

        [ForeignKey("Modulo")]
        public int IdModulo { get; set; }

        [ForeignKey("Usuario")]
        public int IdUusario { get; set; }

        [Required]
        public required bool PermiteAlta { get; set; }

        [Required]
        public required bool PermiteBaja { get; set; }

        [Required]
        public required bool PermiteConsulta { get; set; }


        [Required]
        public required bool PermiteModificacion { get; set; }

    }
}
