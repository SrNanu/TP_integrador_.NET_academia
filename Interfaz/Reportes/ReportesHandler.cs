using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetLight;
using System.Data;


namespace Interfaz.Reportes
{
    public class ReportesHandler
    {

        public ReportesHandler()
        {

        }

        public static async Task GenerateCursosReport()
        {

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pathFile = desktopPath + "\\ReporteCursos_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

            SLDocument oSLDocument = new SLDocument();

            DataTable table = new DataTable();

            //Columnas

            table.Columns.Add("Id_Curso", typeof(int));
            table.Columns.Add("Id_Materia", typeof(int));
            table.Columns.Add("Id_Comision", typeof(int));
            table.Columns.Add("Anio_Calendario", typeof(int));
            table.Columns.Add("Cupo", typeof(int));
            table.Columns.Add("Cupo_Restante", typeof(int));

            // Obtengo los cursos de la API
            IEnumerable<Curso> cursos = await ApiClients.CursoApiClient.GetAllAsync();
            IEnumerable<AlumnoInscripcion> inscripciones = await ApiClients.AlumnoInscripcionApiClient.GetAllAsync();

            // Populate DataTable rows with data from cursos
            foreach (var c in cursos)
            {

                int cupoOcupado = inscripciones.Count(i => i.IdCurso == c.Id);

                int Cupo_Restante = c.Cupo - cupoOcupado;

                table.Rows.Add(c.Id, c.IdMateria, c.IdComision, c.AnioCalendario, c.Cupo, Cupo_Restante);
            }

            oSLDocument.ImportDataTable(1, 1, table, true);
            oSLDocument.SaveAs(pathFile);
        }

        public static async Task GeneratePlanesReport()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string pathFile = desktopPath + "\\ReportePlanes_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

            SLDocument oSLDocument = new SLDocument();

            DataTable table = new DataTable();

            //Columnas

            table.Columns.Add("Id_Planes", typeof(int));
            table.Columns.Add("Desc_Plan", typeof(String));
            table.Columns.Add("Id_Especialidad", typeof(int));
            table.Columns.Add("Desc_Especialidad", typeof(String));

            //Registros

            IEnumerable<Plan> planes = await ApiClients.PlanApiClient.GetAllAsync();
            IEnumerable<Especialidad> especialidades = await ApiClients.EspecialidadApiClient.GetAllAsync();

            foreach (var p in planes)
            {

                Especialidad  laEsp = especialidades.First(e => e.Id == p.IdEspecialidad);

                table.Rows.Add(p.Id, p.Descripcion, laEsp.Id, laEsp.Descripcion);
            }

            oSLDocument.ImportDataTable(1, 1, table, true);
            oSLDocument.SaveAs(pathFile);
        }



    }

}
