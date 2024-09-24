using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class EntidadNegocio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Es para que la BDD genere automaticamente la primary key. Verificar si funciona con la mia
    public int Id { get; set; }

    [Required]
}
