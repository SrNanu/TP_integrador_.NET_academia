using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Materia : EntidadNegocio
{
    [StringLength(100)]
    public  string Descripcion { get; set; }

    [ForeignKey("Plan")]
    public int IdPlan { get; set; }

    public  int HsSemanales { get; set; }

    public  int HsTotales { get; set; }
}
