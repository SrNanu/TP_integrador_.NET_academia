﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Plan : EntidadNegocio
    {
        [Key]
        public int IdPlan { get; set; }

        [ForeignKey("Especialidad")]
        public int IdEspecialidad { get; set; }

        [Required]
        [StringLength(100)]
        public required string Descripcion { get; set; }
    }
}