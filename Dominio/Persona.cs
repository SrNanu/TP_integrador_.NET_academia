﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TiposPersonas        // ¿Dejo el public? Si voy a acceder desde afuera si. Lo analizo al final.
{
    Alumno,     // 0
    Profesor    // 1
}

namespace Dominio
{
    public class Persona : EntidadNegocio
    {
        //Se coloca "required" adelante de cada atributo para que no salte error, se lo deja hasta que se complete el constructor.

        [Key]
        public int IdPersona { get; set; }

        [ForeignKey("Plan")]
        public int IdPlan { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public required string Apellido { get; set; }

        [Required]
        public float? Edad { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(200)]
        public required string Direccion { get; set; }

        [Required]
        private TiposPersonas Tipo { get; set; }

        [StringLength(100)]
        public string? Telefono { get; set; }

        [Required]
        public required int Legajo { get; set; }

        [Required]
        [StringLength(150)]
        public required string Email { get; set; }

        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        [StringLength(20)]
        public required string Password { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        public required bool Habilitado { get; set; }
    }
}
