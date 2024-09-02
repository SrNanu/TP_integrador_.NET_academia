using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class EntidadNegocio
    {
        //Se coloca "required adelante de cada atributo para que no salte error, se lo deja hasta que se complete el constructor."

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public required string State { get; set; }

    }
}
