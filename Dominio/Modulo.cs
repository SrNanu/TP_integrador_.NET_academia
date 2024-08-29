using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Modulo : BusinessEntity
    {
        [Key]
        public int IdModulo { get; set; }

        [Required]
        [StringLength(150)]
        public required string Descripcion { get; set; }

    }
}
