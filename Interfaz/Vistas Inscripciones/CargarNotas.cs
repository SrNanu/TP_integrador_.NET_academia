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

namespace Interfaz.Vistas_Inscripciones
{
    public partial class CargarNota : Form
    {
        public CargarNota()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {

            IEnumerable<AlumnoInscripcion> inscripciones = await AlumnoInscripcionApiClient.GetAllAsync();

            if (inscripciones.Any())
            {
                AlumnoInscripcion alumnoPedido = inscripciones.First(i => i.IdCurso == (int.Parse(txtbIDCurso.Text))
                                                                     && i.IdAlumno == int.Parse(txtbIDAlumno.Text));
                if (alumnoPedido != null)
                {
                    if (alumnoPedido.Nota == 0)
                    {
                        if (int.Parse(txtbNota.Text) >= 0 && int.Parse(txtbNota.Text) <= 10)
                        {
                            alumnoPedido.Nota = int.Parse(txtbNota.Text);

                            if(int.Parse(txtbNota.Text) > 6)
                            {
                                alumnoPedido.Condicion = "Aprobado";
                            }
                            else
                            {
                                alumnoPedido.Condicion = "Libre";
                            }

                            this.Close();


                            await AlumnoInscripcionApiClient.UpdateAsync(alumnoPedido);
                        }
                        else
                        {
                            MessageBox.Show("La nota debe ser un numero entero entre 1 y 10");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ya se ha cargado una nota para este alumno en este curso");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ese Alumno inscripto en ese Curso");
                }

            }
            else 
            {
                MessageBox.Show("No hay inscripciones cargadas");
            } 

        }
    }
}
