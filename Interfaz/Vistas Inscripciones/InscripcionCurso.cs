using Dominio.Entidades;
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
    public partial class InscripcionCurso : Form
    {

        internal Usuario? UsuarioLogeado { get; set; }

        public InscripcionCurso()
        {
            InitializeComponent();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {


            if (txtbIDCurso.Text != "")
            {
                IEnumerable<Curso> allCursos = await CursoApiClient.GetAllAsync();

                Curso existeCurso = allCursos.First(curso => curso.Id == int.Parse(txtbIDCurso.Text));

                

                if (existeCurso != null)
                {

                    IEnumerable<AlumnoInscripcion> inscripciones = await AlumnoInscripcionApiClient.GetAllAsync();

                    int cupoRestante = existeCurso.Cupo - inscripciones.Count(i => i.IdCurso == existeCurso.Id);

                    if (cupoRestante > 0)
                    {

                        AlumnoInscripcion inscripcion = new AlumnoInscripcion();

                        inscripcion.IdCurso = int.Parse(txtbIDCurso.Text);
                        inscripcion.IdAlumno = UsuarioLogeado.Id;
                        inscripcion.Condicion = "Regular";
                        inscripcion.Nota = 0;

                        await AlumnoInscripcionApiClient.AddAsync(inscripcion);

                        MessageBox.Show("Inscripción realizada con éxito.");

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("El curso no tiene cupo disponible.");
                    }
                }
                else
                {
                    MessageBox.Show("El curso no existe.");
                }


            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
