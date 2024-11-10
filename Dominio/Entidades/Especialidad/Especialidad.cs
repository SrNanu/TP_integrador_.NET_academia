using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Especialidad : EntidadNegocio
{
    
    [StringLength(150)]
    public string Descripcion { get; set; }
}

