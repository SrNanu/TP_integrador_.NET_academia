using System.ComponentModel.DataAnnotations.Schema;

public class DocenteCurso : EntidadNegocio
{
    [ForeignKey("Curso")]
    public int IdCurso { get; set; }

    [ForeignKey("Docente")]
    public int IdDocente { get; set; }

}
