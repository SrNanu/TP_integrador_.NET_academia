using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Especialidad_Controller
{
    public static void CrearEspecialidad(/*int idEspecialidad, */string descripcion)
    {
        using (var context = new AcademiaContext())
        {
            var especialidad = new Especialidad()
            {
                //IdEspecialidad = id,
                Descripcion = descripcion
            };

            context.Especialidades.Add(especialidad);
            context.SaveChanges();
            Console.WriteLine($"Especialidad creado: ID: {especialidad.IdEspecialidad}, Descripcion: {especialidad.Descripcion}");
        }
    }

    public static void LeerEspecialidad(int idEspecialidad)
    {
        using (var context = new AcademiaContext())
        {
            var especialidad = context.Especialidades.FirstOrDefault(e => e.IdEspecialidad == idEspecialidad);
            if (especialidad != null)
            {
                Console.WriteLine($"Especialidad creado: ID: {especialidad.IdEspecialidad}, Descripcion: {especialidad.Descripcion}");
            }
            else
            {
                Console.WriteLine("Especialidad no encontrado.");
            }
        }
    }

    public static void ActualizarEspecialidad(int idEspecialidad)
    {

        using (var context = new AcademiaContext())
        {
            var especialidad = context.Especialidades.FirstOrDefault(e => e.IdEspecialidad == idEspecialidad);
            if (especialidad != null)
            {
                Console.Write("\nIngrese la nueva descripción: ");
                especialidad.Descripcion = Console.ReadLine();
                context.SaveChanges();
                Console.WriteLine($"Especialidad creado: ID: {especialidad.IdEspecialidad}, Descripcion: {especialidad.Descripcion}");
            }
            else
            {
                Console.WriteLine("Especialidad no encontrado.");
            }
        }

    }

    public static void EliminarEspecialidad(int idEspecialidad)
    {
        using (var context = new AcademiaContext())
        {
            var especialidad = context.Especialidades.FirstOrDefault(e => e.IdEspecialidad == idEspecialidad);
            if (especialidad != null)
            {
                context.Especialidades.Remove(especialidad);
                context.SaveChanges();
                Console.WriteLine($"Especialidad creado: ID: {especialidad.IdEspecialidad}, Descripcion: {especialidad.Descripcion}");
            }
            else
            {
                Console.WriteLine("Especialidad no encontrado.");
            }
        }
    }
}
