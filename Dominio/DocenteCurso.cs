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

namespace Dominio
{
    public class DocenteCurso : EntidadNegocio
    {
        [Key]
        public int IdDocenteCurso { get; set; }

        [ForeignKey("Curso")]
        public int IdCurso { get; set; }

        [ForeignKey("Docente")]
        public int IdDocente { get; set; }

        [Required]
        private TiposCargos Cargo { get; set; }

    }
}
