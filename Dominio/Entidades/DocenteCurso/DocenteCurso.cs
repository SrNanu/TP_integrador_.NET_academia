using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TiposCargos
{
    ProfesorTeoria,     // 0
    ProfesorPractica    // 1
}

public class DocenteCurso : EntidadNegocio
{
    [ForeignKey("Curso")]
    public int IdCurso { get; set; }

    [ForeignKey("Usuario")]
    public int IdDocente { get; set; }

    public TiposCargos Cargo { get; set; }

}
