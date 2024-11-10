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
    
    public partial class MateriaDetalle : Form

    {
        private Materia materia;
        private ErrorProvider errorProvider;

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();
            }
        }

        public bool EditMode { get; set; } = false;

        public MateriaDetalle()
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
                MateriaApiClient client = new MateriaApiClient();

                if (this.ValidateMateria())
                {
                    // Asignar los valores de los TextBoxes a la materia
                    this.Materia.Descripcion = txtbDescripcion.Text; // Obtener Descripción
                    this.Materia.IdPlan = (int)cmbPlanes.SelectedValue; // Obtener el Id del Plan seleccionado
                    this.Materia.HsSemanales = int.Parse(txtbHsSemanales.Text); // Obtener Horas Semanales
                    this.Materia.HsTotales = int.Parse(txtbHsTotales.Text); // Obtener Horas Totales

                    if (this.EditMode)
                    {
                        await MateriaApiClient.UpdateAsync(this.Materia);
                    }
                    else
                    {
                        await MateriaApiClient.AddAsync(this.Materia);
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

        private void SetMateria()
        {
            this.txtbDescripcion.Text = this.Materia.Descripcion; // Establecer la descripción
            
            if (Materia != null && Materia.IdPlan != 0) // Seleccionar el plan en el ComboBox según el Id del Materia
            {
            this.cmbPlanes.SelectedValue = this.Materia.IdPlan;
            }
            this.txtbHsSemanales.Text = this.Materia.HsSemanales.ToString(); // Establecer horas semanales
            this.txtbHsTotales.Text = this.Materia.HsTotales.ToString(); // Establecer horas totales
        }

        private bool ValidateMateria()
        {
            bool isValid = true;

            // Limpiar errores previos
            errorProvider.Clear();

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(txtbDescripcion.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbDescripcion, "La Descripción es requerida.");
            }

            // Validar que seleccione un plan
            if (cmbPlanes.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cmbPlanes, "Debe seleccionar un Plan.");
            }

            // Validar Horas Semanales
            if (string.IsNullOrWhiteSpace(txtbHsSemanales.Text) || !int.TryParse(txtbHsSemanales.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(txtbHsSemanales, "Debe ingresar un número válido de Horas Semanales.");
            }

            // Validar Horas Totales
            if (string.IsNullOrWhiteSpace(txtbHsTotales.Text) || !int.TryParse(txtbHsTotales.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(txtbHsTotales, "Debe ingresar un número válido de Horas Totales.");
            }

            return isValid;
        }
    }

}
