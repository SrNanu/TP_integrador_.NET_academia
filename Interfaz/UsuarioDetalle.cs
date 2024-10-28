using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz.ApiClients;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class UsuarioDetalle : Form
    {
        private Usuario usuario;
        private ErrorProvider errorProvider; // Add this line

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetUsuario();
            }
        }

        public bool EditMode { get; set; } = false;
        public UsuarioDetalle()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(); // Add this line
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioApiClient client = new UsuarioApiClient();

            if (this.ValidateUsuario())
            {
                this.Usuario.Nombre = txtbNombre.Text;

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await UsuarioApiClient.UpdateAsync(this.Usuario);
                }
                else
                {
                    await UsuarioApiClient.AddAsync(this.Usuario);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUsuario()
        {
            this.txtbNombre.Text = this.Usuario.Nombre;
        }

        private bool ValidateUsuario()
        {
            bool isValid = true;

            errorProvider.SetError(txtbNombre, string.Empty);

            if (this.txtbNombre.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtbNombre, "El Nombre es Requerido");
            }

            return isValid;
        }
    }
}
