using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Modulo_Controller
{
    public static void CrearModulo(string descripcion)
    {
        using (var context = new AcademiaContext())
        {
            var modulo = new Modulo()
            {
                Descripcion = descripcion
            };

            context.Modulos.Add(modulo);
            context.SaveChanges();
            Console.WriteLine($"Modulo creado: ID: {modulo.Id}, Descripcion: {modulo.Descripcion}");
        }
    }

    public static void LeerModulo(int id)
    {
        using (var context = new AcademiaContext())
        {
            var modulo = context.Modulos.FirstOrDefault(m => m.Id == id);
            if (modulo != null)
            {
                Console.WriteLine($"Modulo leido: ID: {modulo.Id}, Descripcion: {modulo.Descripcion}");
            }
            else
            {
                Console.WriteLine("Modulo no encontrado.");
            }
        }
    }

    public static void ActualizarModulo(int id)
    {

        using (var context = new AcademiaContext())
        {
            var modulo = context.Modulos.FirstOrDefault(m => m.Id == id);
            if (modulo != null)
            {
                Console.Write("\nIngrese la nueva descripción: ");
                modulo.Descripcion = Console.ReadLine();
                context.SaveChanges();
                Console.WriteLine($"Modulo actualizado: ID: {modulo.Id}, Descripcion: {modulo.Descripcion}");
            }
            else
            {
                Console.WriteLine("Modulo no encontrado.");
            }
        }

    }

    public static void EliminarModulo(int id)
    {
        using (var context = new AcademiaContext())
        {
            var modulo = context.Modulos.FirstOrDefault(m => m.Id == id);
            if (modulo != null)
            {
                context.Modulos.Remove(modulo);
                context.SaveChanges();
                Console.WriteLine($"Modulo eliminado: ID: {modulo.Id}, Descripcion: {modulo.Descripcion}");
            }
            else
            {
                Console.WriteLine("Modulo no encontrado.");
            }
        }
    }
}
