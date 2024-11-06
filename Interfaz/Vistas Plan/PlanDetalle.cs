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
    public partial class PlanDetalle : Form
    {
        private Plan plan;
        private ErrorProvider errorProvider;

        public Plan Plan
        {
            get { return plan; }
            set
            {
                plan = value;
                this.SetPlan();
            }
        }

        public bool EditMode { get; set; } = false;

        public PlanDetalle()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            LoadEspecialidades(); // Cargar especialidades al iniciar el formulario
        }

        private async void LoadEspecialidades()
        {
            // Llama al API o a la base de datos para obtener la lista de especialidades
            List<Especialidad> especialidades = (List<Especialidad>)await EspecialidadApiClient.GetAllAsync();

            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.DisplayMember = "Descripcion"; // Mostrar la descripción
            cmbEspecialidades.ValueMember = "Id"; // El valor será el Id de la especialidad
        }
        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            PlanApiClient client = new PlanApiClient();

            if (this.ValidatePlan())
            {
                // Asignar el ID de Especialidad y la Descripción
                //this.Plan.IdEspecialidad = int.Parse(txtbIdEspecialidad.Text); // Obtener ID de Especialidad
                this.Plan.Descripcion = txtbDetalles.Text; // Obtener Descripción
                this.Plan.IdEspecialidad = (int)cmbEspecialidades.SelectedValue;

                if (this.EditMode)
                {
                    await PlanApiClient.UpdateAsync(this.Plan);
                }
                else
                {
                    await PlanApiClient.AddAsync(this.Plan);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPlan()
        {
            this.txtbDetalles.Text = this.Plan.Descripcion; // Establecer la descripción
            if (Plan != null && Plan.IdEspecialidad != 0)
            {
                cmbEspecialidades.SelectedValue = this.Plan.IdEspecialidad;
            }
        }

        private bool ValidatePlan()
        {
            bool isValid = true;

            // Limpiar errores previos
            errorProvider.Clear();

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(txtbDetalles.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbDetalles, "La Descripción es requerida.");
            }

            //Validar Especialidad seleccionada
            if (cmbEspecialidades.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cmbEspecialidades, "Debe seleccionar una Especialidad.");
            }

            return isValid;
        }

        private void PlanDetalle_Load(object sender, EventArgs e)
        {

        }
    }

}
