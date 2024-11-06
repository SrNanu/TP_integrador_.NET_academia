using Interfaz.ApiClients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Vistas_Cursos
{
    /*
    public partial class CursoLista : Form
    {
        public CursoLista()
        {
            InitializeComponent();
        }
    }
    */
    public partial class CursoLista : Form
    {
        public CursoLista()
        {
            InitializeComponent();
            this.GetAllAndLoad();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            CursoDetalle cursoDetalle = new CursoDetalle();

            Curso cursoNuevo = new Curso();
            cursoNuevo.AnioCalendario = DateTime.Now.Year;

            cursoDetalle.Curso = cursoNuevo;

            cursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            CursoDetalle cursoDetalle = new CursoDetalle();

            int id = this.SelectedItem().Id;

            Curso curso = await CursoApiClient.GetAsync(id);

            cursoDetalle.EditMode = true;
            cursoDetalle.Curso = curso;

            cursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;
            await CursoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            CursoApiClient client = new CursoApiClient();

            this.cursosDataGridView.DataSource = null;
            this.cursosDataGridView.DataSource = await CursoApiClient.GetAllAsync();

            if (this.cursosDataGridView.Rows.Count > 0)
            {
                this.cursosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Curso SelectedItem()
        {
            return (Curso)cursosDataGridView.SelectedRows[0].DataBoundItem;
        }
    }


}
