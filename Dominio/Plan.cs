using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Plan : BusinessEntity
    {
        //Se coloca "required adelante de cada atributo para que no salte error, se lo deja hasta que se complete el constructor."

        [Key]
        public int IdPlan { get; set; }

        [Required]
        [StringLength(100)]
        public required string Descripcion { get; set; }
    }
}
