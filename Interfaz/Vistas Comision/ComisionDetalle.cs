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
    //public partial class ComisionDetalle : Form
    //{
    //    public ComisionDetalle()
    //    {
    //        InitializeComponent();
    //    }
    //}

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
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ComisionApiClient client = new ComisionApiClient();

            if (this.ValidateComision())
            {
                this.Comision.IdPlan = int.Parse(txtbIdPlan.Text);
                this.Comision.Descripcion = txtbIdDescripcion.Text;
                this.Comision.AnioEspecialidad = int.Parse(txtbAnioEspecialidad.Text);

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

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetComision()
        {
            this.txtbIdPlan.Text = this.Comision.IdPlan.ToString();
            this.txtbIdDescripcion.Text = this.Comision.Descripcion;
            this.txtbAnioEspecialidad.Text = this.Comision.AnioEspecialidad.ToString();
        }

        private bool ValidateComision()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar IdPlan
            if (!int.TryParse(txtbIdPlan.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(txtbIdPlan, "El ID del Plan debe ser un número entero.");
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
