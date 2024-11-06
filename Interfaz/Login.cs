using Interfaz.ApiClients;
using Interfaz.Vistas_Profesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void IniciarSesion(object sender, EventArgs e)
        {
            //Validacion de usuario y contraseña

            UsuarioApiClient client = new UsuarioApiClient();


            if (txtbUsuario.Text != "" && txtbContrasenia.Text != "") 
                {

                IEnumerable<Usuario> allUsers = await UsuarioApiClient.GetAllAsync();

                bool existeUsuario = allUsers.Any(user => user.Username == txtbUsuario.Text);

                if (existeUsuario)
                {
                    Usuario unUsuario = allUsers.First(user => user.Username == txtbUsuario.Text);

                    if (unUsuario.Password == txtbContrasenia.Text)
                    {

                        if (unUsuario.Tipo == TiposUsuarios.Alumno) 
                        {
                            //Alumno
                            MenuAlumnos menu = new MenuAlumnos();

                            menu.Show();

                            menu.Activate();

                            this.Dispose();

                        }
                        else if (unUsuario.Tipo == TiposUsuarios.Profesor)
                        {
                            //Profesor
                            MenuProfesor menu = new MenuProfesor();

                            menu.Show();

                            menu.Activate();

                            this.Dispose();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }


            }
            else {
                MessageBox.Show("Porfavor llene los campos para ingresar", "Atencion");

            };

        }

        private void Registarse(object sender, EventArgs e)
        {
            //Registrarse

            AlumnosDetalle formRegistracion = new AlumnosDetalle();

            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.FechaNacimiento = DateTime.Now.AddYears(-18);

            formRegistracion.Usuario = nuevoUsuario;
            

            formRegistracion.ShowDialog();

        }
    }
}
