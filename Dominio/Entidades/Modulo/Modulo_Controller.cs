using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Modulo_Controller
{
    public static void CrearModulo(/*int idModulo, */string descripcion)
    {
        using (var context = new AcademiaContext())
        {
            var modulo = new Modulo()
            {
                //IdModulo = id,
                Descripcion = descripcion
            };

            context.Modulos.Add(modulo);
            context.SaveChanges();
            Console.WriteLine($"Modulo creado: ID: {modulo.IdModulo}, Descripcion: {modulo.Descripcion}");
        }
    }

    public static void LeerModulo(int idModulo)
    {
        using (var context = new AcademiaContext())
        {
            var modulo = context.Modulos.FirstOrDefault(m => m.IdModulo == idModulo);
            if (modulo != null)
            {
                Console.WriteLine($"Modulo creado: ID: {modulo.IdModulo}, Descripcion: {modulo.Descripcion}");
            }
            else
            {
                Console.WriteLine("Modulo no encontrado.");
            }
        }
    }

    public static void ActualizarModulo(int idModulo)
    {

        using (var context = new AcademiaContext())
        {
            var modulo = context.Modulos.FirstOrDefault(m => m.IdModulo == idModulo);
            if (modulo != null)
            {
                Console.Write("\nIngrese la nueva descripción: ");
                modulo.Descripcion = Console.ReadLine();
                context.SaveChanges();
                Console.WriteLine($"Modulo creado: ID: {modulo.IdModulo}, Descripcion: {modulo.Descripcion}");
            }
            else
            {
                Console.WriteLine("Modulo no encontrado.");
            }
        }

    }

    public static void EliminarModulo(int idModulo)
    {
        using (var context = new AcademiaContext())
        {
            var modulo = context.Modulos.FirstOrDefault(m => m.IdModulo == idModulo);
            if (modulo != null)
            {
                context.Modulos.Remove(modulo);
                context.SaveChanges();
                Console.WriteLine($"Modulo creado: ID: {modulo.IdModulo}, Descripcion: {modulo.Descripcion}");
            }
            else
            {
                Console.WriteLine("Modulo no encontrado.");
            }
        }
    }
}
