using Interfaz.Vistas_Especialidad;
using Interfaz.Vistas_Materia;
using Interfaz.Vistas_Plan;
using Interfaz.Vistas_Materia;
using Interfaz.Vistas_Cursos;
using Interfaz.Vistas_Comision;


namespace Interfaz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CursoLista());


            Application.Run();
        }
    }
}