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

namespace Interfaz.Vistas_Plan
{
    
    public partial class PlanLista : Form
    {
        public PlanLista()
        {
            InitializeComponent();
            this.GetAllAndLoad();
        }
        
        private void Planes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            
            PlanDetalle planDetalle = new PlanDetalle();

            Plan planNuevo = new Plan();
            // Aquí puedes inicializar el planNuevo con valores predeterminados si es necesario

            planDetalle.Plan = planNuevo;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
            
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            
            PlanDetalle planDetalle = new PlanDetalle();

            int id = this.SelectedItem().Id;

            Plan plan = await PlanApiClient.GetAsync(id);

            planDetalle.EditMode = true;
            planDetalle.Plan = plan;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
            
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;
            await PlanApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            PlanApiClient client = new PlanApiClient();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = await PlanApiClient.GetAllAsync();

            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Plan SelectedItem()
        {
            Plan plan = (Plan)dataGridView1.SelectedRows[0].DataBoundItem;

            return plan;
        }
    }


}
