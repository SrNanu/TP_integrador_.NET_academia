using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
/*
public enum State
{
    Leer,      // 0
    Crear,    // 1
    Modificar, //2
    Borrar      //3
}
*/
=======


>>>>>>> 9145ed5a51bde9c7a79dd51e1719ac055ea55ab8

public abstract class EntidadNegocio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Es para que la BDD genere automaticamente la primary key. Verificar si funciona con la mia
    public int Id { get; set; }
    /*
    [Required]
<<<<<<< HEAD
    public required State State { get; set; }
    */
=======
>>>>>>> 9145ed5a51bde9c7a79dd51e1719ac055ea55ab8
}
