﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Plan : EntidadNegocio
{
    [ForeignKey("Especialidad")]
    public int IdEspecialidad { get; set; }

    [StringLength(100)]
    public  string Descripcion { get; set; }
}
