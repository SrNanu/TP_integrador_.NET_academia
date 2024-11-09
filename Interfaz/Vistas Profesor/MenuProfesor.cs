using Interfaz.Reportes;
using Interfaz.Vistas_Comision;
using Interfaz.Vistas_Cursos;
using Interfaz.Vistas_Especialidad;
using Interfaz.Vistas_Materia;
using Interfaz.Vistas_Plan;
using Interfaz.Vistas_Inscripciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Vistas_Profesor
{
    public partial class MenuProfesor : Form
    {
        public MenuProfesor()
        {
            InitializeComponent();
        }

        private void lknLogOut_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();

            formLogin.Show();

            formLogin.Activate();

            this.Dispose();
        }

        private void OpenMaterias(object sender, EventArgs e)
        {

            MateriaLista formMaterias = new MateriaLista();

            formMaterias.ShowDialog();

        }

        private void OpenEspecialidades(object sender, EventArgs e)
        {
            EspecialidadLista formEspecialidades = new EspecialidadLista();

            formEspecialidades.ShowDialog();

        }

        private void OpenCursos(object sender, EventArgs e)
        {
            CursoLista formCurso = new CursoLista();

            formCurso.ShowDialog();

        }

        private void OpenPlanes(object sender, EventArgs e)
        {
            PlanLista formPlanes = new PlanLista();

            formPlanes.ShowDialog();

        }

        private void OpenComisiones(object sender, EventArgs e)
        {
            ComisionLista formComisiones = new ComisionLista();

            formComisiones.ShowDialog();

        }

        private async void GenerarReportePlanes(object sender, EventArgs e)
        {
            await ReportesHandler.GeneratePlanesReport();
            MessageBox.Show("Reporte creado en el Escritorio", "Exito");
        }

        private async void GenerarReporteCursos(object sender, EventArgs e)
        {
            await ReportesHandler.GenerateCursosReport();
            MessageBox.Show("Reporte creado en el Escritorio", "Exito");

        }


        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            CargarNota formCargarNotas = new CargarNota();

            formCargarNotas.ShowDialog();
        }
    }
}
