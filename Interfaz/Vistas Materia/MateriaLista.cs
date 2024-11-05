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

namespace Interfaz.Vistas_Materia
{
    /*
    public partial class MateriaLista : Form
    {   

        public MateriaLista()
        {
            InitializeComponent();
        }

        private void MateriaLista_Load(object sender, EventArgs e)
        {

        }
    }
    */
    public partial class MateriaLista : Form
    {
        public MateriaLista()
        {
            InitializeComponent();
            this.GetAllAndLoad();
        }

        private void MateriaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            MateriaDetalle materiaDetalle = new MateriaDetalle();

            Materia nuevaMateria = new Materia();

            materiaDetalle.Materia = nuevaMateria;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            MateriaDetalle materiaDetalle = new MateriaDetalle();

            int id = this.SelectedItem().Id;

            Materia materia = await MateriaApiClient.GetAsync(id);

            materiaDetalle.EditMode = true;
            materiaDetalle.Materia = materia;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;
            await MateriaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            MateriaApiClient client = new MateriaApiClient();

            this.materiasDataGridView.DataSource = null;
            this.materiasDataGridView.DataSource = await MateriaApiClient.GetAllAsync();

            if (this.materiasDataGridView.Rows.Count > 0)
            {
                this.materiasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Materia SelectedItem()
        {
            Materia materia;

            materia = (Materia)materiasDataGridView.SelectedRows[0].DataBoundItem;

            return materia;
        }
    }

}
