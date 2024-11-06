using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaz.ApiClients;

namespace Interfaz
{
    public partial class AlumnosLista : Form
    {
        public AlumnosLista()
        {
            InitializeComponent();
            this.GetAllAndLoad();

        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AlumnosDetalle usuarioDetalle = new AlumnosDetalle();

            Usuario usuarioNuevo = new Usuario();
            usuarioNuevo.FechaNacimiento = DateTime.Now.AddYears(-18);

            usuarioDetalle.Usuario = usuarioNuevo;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            AlumnosDetalle usuarioDetalle = new AlumnosDetalle();

            int id;

            id = this.SelectedItem().Id;

            Usuario usuario = await UsuarioApiClient.GetAsync(id);

            usuarioDetalle.EditMode = true;
            usuarioDetalle.Usuario = usuario;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await UsuarioApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }


        private async void GetAllAndLoad()
        {
            UsuarioApiClient client = new UsuarioApiClient();

            this.usuariosDataGridView.DataSource = null;
            this.usuariosDataGridView.DataSource = await UsuarioApiClient.GetAllAsync();

            if (this.usuariosDataGridView.Rows.Count > 0)
            {
                this.usuariosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Usuario SelectedItem()
        {
            Usuario usuario;

            usuario = (Usuario)usuariosDataGridView.SelectedRows[0].DataBoundItem;

            return usuario;
        }

    }
}
