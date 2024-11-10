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

namespace Interfaz.Vistas_Especialidad
{
    /*
    public partial class EspecialidadLista : Form
    {
        public EspecialidadLista()
        {
            InitializeComponent();
        }
    }
    */
    public partial class EspecialidadLista : Form
    {
        public EspecialidadLista()
        {
            InitializeComponent();
            this.GetAllAndLoad();
        }

        private void EspecialidadLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            EspecialidadDetalle especialidadDetalle = new EspecialidadDetalle();
            Especialidad especialidadNueva = new Especialidad();

            especialidadDetalle.Especialidad = especialidadNueva;

            especialidadDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            EspecialidadDetalle especialidadDetalle = new EspecialidadDetalle();

            int id = this.SelectedItem().Id;

            Especialidad especialidad = await EspecialidadApiClient.GetAsync(id);

            especialidadDetalle.EditMode = true;
            especialidadDetalle.Especialidad = especialidad;

            especialidadDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;
            await EspecialidadApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            EspecialidadApiClient client = new EspecialidadApiClient();

            this.especialidadesDataGridView.DataSource = null;
            this.especialidadesDataGridView.DataSource = await EspecialidadApiClient.GetAllAsync();

            if (this.especialidadesDataGridView.Rows.Count > 0)
            {
                this.especialidadesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Especialidad SelectedItem()
        {
            return (Especialidad)especialidadesDataGridView.SelectedRows[0].DataBoundItem;
        }
    }

}
