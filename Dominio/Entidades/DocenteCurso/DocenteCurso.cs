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
    [NotMapped] // Evita que esta propiedad se trate como una columna nueva en la BD
    public int IdDocenteCurso
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    [ForeignKey("Curso")]
    public int IdCurso { get; set; }

    [ForeignKey("Docente")]
    public int IdDocente { get; set; }

    [Required]
    private TiposCargos Cargo { get; set; }

}
