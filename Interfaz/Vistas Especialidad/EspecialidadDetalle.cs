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
    public partial class EspecialidadDetalle : Form
    {
        public EspecialidadDetalle()
        {
            InitializeComponent();
        }
    }
    */
    public partial class EspecialidadDetalle : Form
    {
        private Especialidad especialidad;
        private ErrorProvider errorProvider;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set
            {
                especialidad = value;
                this.SetEspecialidad();
            }
        }

        public bool EditMode { get; set; } = false;

        public EspecialidadDetalle()
        {

            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                EspecialidadApiClient client = new EspecialidadApiClient();

                if (this.ValidateEspecialidad())
                {
                    this.Especialidad.Descripcion = txtbDescripcion.Text;

                    if (this.EditMode)
                    {
                        await EspecialidadApiClient.UpdateAsync(this.Especialidad);
                    }
                    else
                    {
                        await EspecialidadApiClient.AddAsync(this.Especialidad);
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

        private void SetEspecialidad()
        {
            this.txtbDescripcion.Text = this.Especialidad.Descripcion;
        }

        private bool ValidateEspecialidad()
        {
            bool isValid = true;

            errorProvider.Clear();

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(txtbDescripcion.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbDescripcion, "La Descripción es requerida.");
            }

            return isValid;
        }
    }

}
