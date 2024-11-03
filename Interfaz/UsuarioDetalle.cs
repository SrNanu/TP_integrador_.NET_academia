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
                this.Usuario.Apellido = txtbApellido.Text;
                this.Usuario.FechaNacimiento = dtpFechaNacimiento.Value;
                this.Usuario.Direccion = txtbDireccion.Text;
                this.Usuario.Telefono = txtbTelefono.Text;
                this.Usuario.Email = txtbEmail.Text;
                this.Usuario.Username = txtbUsuario.Text;
                this.Usuario.Password = txtbContrasenia.Text;

                // Asignar el tipo de usuario seleccionado en el ComboBox
                this.Usuario.Tipo = (TiposUsuarios)Enum.Parse(typeof(TiposUsuarios), cmbTipo.SelectedItem.ToString());

                // Asignar la edad en función de la FechaNacimiento



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
            this.txtbApellido.Text = this.Usuario.Apellido;
            this.dtpFechaNacimiento.Text = this.Usuario.FechaNacimiento.ToString();
            this.txtbDireccion.Text = this.Usuario.Direccion;
            this.txtbTelefono.Text = this.Usuario.Telefono;
            this.txtbEmail.Text = this.Usuario.Email;
            this.txtbUsuario.Text = this.Usuario.Username;
            this.txtbContrasenia.Text = this.Usuario.Password;

            // Marcar el tipo de usuario en el CheckedListBox
            this.cmbTipo.SelectedItem = this.Usuario.Tipo.ToString();

        }

        private bool ValidateUsuario()
        {
            bool isValid = true;

            // Limpiar errores previos
            errorProvider.Clear();

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtbNombre.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbNombre, "El Nombre es requerido.");
            }

            // Validar Apellido
            if (string.IsNullOrWhiteSpace(txtbApellido.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbApellido, "El Apellido es requerido.");
            }

            // Validar Fecha de Nacimiento
            if (dtpFechaNacimiento.Value >= DateTime.Today)
            {
                isValid = false;
                errorProvider.SetError(dtpFechaNacimiento, "La Fecha de Nacimiento debe ser anterior a hoy.");
            }

            // Validar Dirección
            if (string.IsNullOrWhiteSpace(txtbDireccion.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbDireccion, "La Dirección es requerida.");
            }

            // Validar Teléfono (opcional, pero puedes añadir una validación de formato)
            if (!string.IsNullOrWhiteSpace(txtbTelefono.Text) && txtbTelefono.Text.Length < 7)
            {
                isValid = false;
                errorProvider.SetError(txtbTelefono, "El Teléfono debe tener al menos 7 dígitos.");
            }

            // Validar Email
            if (string.IsNullOrWhiteSpace(txtbEmail.Text) || !txtbEmail.Text.Contains("@"))
            {
                isValid = false;
                errorProvider.SetError(txtbEmail, "El Email es requerido y debe tener un formato válido.");
            }

            // Validar Usuario (Username)
            if (string.IsNullOrWhiteSpace(txtbUsuario.Text))
            {
                isValid = false;
                errorProvider.SetError(txtbUsuario, "El Nombre de Usuario es requerido.");
            }

            // Validar Contraseña
            if (string.IsNullOrWhiteSpace(txtbContrasenia.Text) || txtbContrasenia.Text.Length < 6)
            {
                isValid = false;
                errorProvider.SetError(txtbContrasenia, "La Contraseña es requerida y debe tener al menos 6 caracteres.");
            }

            // Validar Tipo de Usuario (ComboBox)
            if (cmbTipo.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cmbTipo, "Debe seleccionar un Tipo de Usuario.");
            }

            return isValid;
        }
    }
}
