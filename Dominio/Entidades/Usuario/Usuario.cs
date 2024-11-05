using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TiposUsuarios
{
    Alumno,         // 0
    Profesor        // 1
}

public class Usuario : EntidadNegocio
{
    //Se coloca "required" adelante de cada atributo para que no salte error, se lo deja hasta que se complete el constructor.
    [ForeignKey("Plan")]
    public int IdPlan { get; set; } //SE QUEDA? PORQUE CUANDO CREA UN USUARIO DE UN ADMINISTRATIVO O PROFESOR NO INTERESA EL PLAN.

    [StringLength(100)]
    public  string Nombre { get; set; }

    [StringLength(100)]
    public  string Apellido { get; set; }

    public DateTime FechaNacimiento { get; set; }

    [StringLength(200)]
    public  string Direccion { get; set; }

    public TiposUsuarios Tipo { get; set; }

    [StringLength(100)]
    public string? Telefono { get; set; }

    public  int Legajo { get; set; }

    [StringLength(150)]
    public  string Email { get; set; }

    [StringLength(50)]
    public  string Username { get; set; }

    [StringLength(20)]
    public  string Password { get; set; }

    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    public bool Habilitado { get; set; }
}