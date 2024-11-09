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
    Docente        // 1
}

public class Usuario : EntidadNegocio
{
    [ForeignKey("Plan")]
    public int? IdPlan { get; set; }        //SE QUEDA? PORQUE CUANDO CREA UN USUARIO DE UN PROFESOR NO INTERESA EL PLAN.

    [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; }

    [StringLength(100, ErrorMessage = "El apellido no puede tener más de 100 caracteres.")]
    [Required(ErrorMessage = "El apellido es obligatorio.")]
    public string Apellido { get; set; }

    [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
    public DateTime FechaNacimiento { get; set; }

    [StringLength(200, ErrorMessage = "La dirección no puede tener más de 200 caracteres.")]
    public string Direccion { get; set; }

    [Required(ErrorMessage = "El tipo de usuario es obligatorio.")]
    public TiposUsuarios Tipo { get; set; }

    [StringLength(100, ErrorMessage = "El teléfono no puede tener más de 100 caracteres.")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "El legajo es obligatorio.")]
    public int Legajo { get; set; }

    [StringLength(150, ErrorMessage = "El correo electrónico no puede tener más de 150 caracteres.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    public string Email { get; set; }

    [StringLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres.")]
    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    public string Username { get; set; }

    [StringLength(20, ErrorMessage = "La contraseña no puede tener más de 20 caracteres.")]
    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    public string Password { get; set; }

    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    public bool Habilitado { get; set; } = true;
}
