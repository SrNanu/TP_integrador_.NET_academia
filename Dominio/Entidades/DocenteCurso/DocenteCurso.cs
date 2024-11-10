using System.ComponentModel.DataAnnotations.Schema;

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

    public TiposCargos? Cargo { get; set; }

}
