﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum State        // ¿Dejo el public?
{
    Guardar,     // 0
    Crear,    // 1
    Modificar,
    Borrar
}

namespace Dominio
{
    public class EntidadNegocio
    {
        //Se coloca "required" adelante de cada atributo para que no salte error, se lo deja hasta que se complete el constructor.

        [Key]
        public int Id { get; set; }

        [Required]
        public required State State { get; set; }

    }
}
