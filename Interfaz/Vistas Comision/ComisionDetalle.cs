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

namespace Interfaz.Vistas_Comision
{
   

    public partial class ComisionDetalle : Form
    {
        private Comision comision;
        private ErrorProvider errorProvider;

        public Comision Comision
        {
            get { return comision; }
            set
            {
                comision = value;
                this.SetComision();
            }
        }

        public bool EditMode { get; set; } = false;

        public ComisionDetalle()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            LoadPlanes(); // Cargar planes al iniciar el formulario
        }

        private async void LoadPlanes()
        {
            // Llama al API o a la base de datos para obtener la lista de planes
            List<Plan> planes = (List<Plan>)await PlanApiClient.GetAllAsync();

            cmbPlanes.DataSource = planes;
            cmbPlanes.DisplayMember = "Descripcion"; // Mostrar la descripción del plan
            cmbPlanes.ValueMember = "Id"; // El valor será el Id del plan
        }
        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ComisionApiClient client = new ComisionApiClient();

                if (this.ValidateComision())
                {
                    this.Comision.Descripcion = txtbIdDescripcion.Text;
                    this.Comision.AnioEspecialidad = int.Parse(txtbAnioEspecialidad.Text);
                    this.Comision.IdPlan = (int)cmbPlanes.SelectedValue;

                    
                    if (this.EditMode)
                    {
                        await ComisionApiClient.UpdateAsync(this.Comision);
                    }
                    else
                    {
                        await ComisionApiClient.AddAsync(this.Comision);
                    }
                    

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetComision()
        {
            this.txtbIdDescripcion.Text = this.Comision.Descripcion;
            this.txtbAnioEspecialidad.Text = this.Comision.AnioEspecialidad.ToString();
            // Seleccionar el plan en el ComboBox según el Id de la comisión
            if (Comision != null)
            {
                cmbPlanes.SelectedValue = this.Comision.IdPlan;
            }
        }

        private bool ValidateComision()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar IdPlan
            if (cmbPlanes.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cmbPlanes, "Debe seleccionar un Plan.");
            }

            // Validar Descripcion
            if (string.IsNullOrWhiteSpace(txtbIdDescripcion.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbIdDescripcion, "La Descripción es requerida.");
            }

            // Validar AnioEspecialidad
            if (!int.TryParse(txtbAnioEspecialidad.Text, out _) || int.Parse(txtbAnioEspecialidad.Text) < 0)
            {
                isValid = false;
                errorProvider.SetError(txtbAnioEspecialidad, "El Año de Especialidad debe ser un número entero positivo.");
            }

            return isValid;
        }
    }

}
