using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Especialidad_Controller
{
    public static void CrearEspecialidad(string descripcion)
    {
        using (var context = new AcademiaContext())
        {
            var especialidad = new Especialidad()
            {
                Descripcion = descripcion
            };

            context.Especialidades.Add(especialidad);
            context.SaveChanges();
            Console.WriteLine($"Especialidad creado: ID: {especialidad.Id}, Descripcion: {especialidad.Descripcion}");
        }
    }

    public static void LeerEspecialidad(int id)
    {
        using (var context = new AcademiaContext())
        {
            var especialidad = context.Especialidades.FirstOrDefault(e => e.Id == id);
            if (especialidad != null)
            {
                Console.WriteLine($"Especialidad encontrada: ID: {especialidad.Id}, Descripcion: {especialidad.Descripcion}");
            }
            else
            {
                Console.WriteLine("Especialidad no encontrado.");
            }
        }
    }

    public static void ActualizarEspecialidad(int id)
    {

        using (var context = new AcademiaContext())
        {
            var especialidad = context.Especialidades.FirstOrDefault(e => e.Id == id);
            if (especialidad != null)
            {
                Console.Write("\nIngrese la nueva descripción: ");
                especialidad.Descripcion = Console.ReadLine();
                context.SaveChanges();
                Console.WriteLine($"Especialidad actualizada: ID: {especialidad.Id}, Descripcion: {especialidad.Descripcion}");
            }
            else
            {
                Console.WriteLine("Especialidad no encontrado.");
            }
        }

    }

    public static void EliminarEspecialidad(int id)
    {
        using (var context = new AcademiaContext())
        {
            var especialidad = context.Especialidades.FirstOrDefault(e => e.Id == id);
            if (especialidad != null)
            {
                context.Especialidades.Remove(especialidad);
                context.SaveChanges();
                Console.WriteLine($"Especialidad eliminada: ID: {especialidad.Id}, Descripcion: {especialidad.Descripcion}");
            }
            else
            {
                Console.WriteLine("Especialidad no encontrado.");
            }
        }
    }
}
