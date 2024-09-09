using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum State
{
    Leer,      // 0
    Crear,    // 1
    Modificar,
    Borrar
}

namespace Dominio
{
    public class EntidadNegocio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required State State { get; set; }

    }
}
