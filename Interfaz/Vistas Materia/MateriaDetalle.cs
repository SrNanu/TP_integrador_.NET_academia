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
    /*
{
    public MateriaDetalle()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }
} */
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
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            MateriaApiClient client = new MateriaApiClient();

            if (this.ValidateMateria())
            {
                // Asignar los valores de los TextBoxes a la materia
                this.Materia.Descripcion = txtbDescripcion.Text; // Obtener Descripción
                this.Materia.IdPlan = int.Parse(txtbIdPlan.Text); // Obtener ID de Plan
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

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetMateria()
        {
            this.txtbDescripcion.Text = this.Materia.Descripcion; // Establecer la descripción
            this.txtbIdPlan.Text = this.Materia.IdPlan.ToString(); // Establecer el ID de plan
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

            // Validar ID de Plan
            if (string.IsNullOrWhiteSpace(txtbIdPlan.Text) || !int.TryParse(txtbIdPlan.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(txtbIdPlan, "Debe ingresar un ID de Plan válido.");
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
