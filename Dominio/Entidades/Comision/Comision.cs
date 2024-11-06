using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Comision : EntidadNegocio
{
    [ForeignKey("Plan")]
    public int IdPlan { get; set; }

    [StringLength(150)]
    public  string Descripcion { get; set; }

    public  int AnioEspecialidad { get; set; }
}
