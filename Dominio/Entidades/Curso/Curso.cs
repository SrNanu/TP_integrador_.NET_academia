using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Curso : EntidadNegocio
{
    [ForeignKey("Comision")]
    public int IdComision { get; set; }

    [ForeignKey("Materia")]
    public int IdMateria { get; set; }

    public int Cupo { get; set; }

    
    public  int AnioCalendario { get; set; }

    
    [StringLength(150)]
    public  string Descripcion { get; set; }
}
