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

namespace Interfaz.Vistas_Cursos
{
    /*
    public partial class CursoDetalle : Form
    {   
        
        public CursoDetalle()
        {
            InitializeComponent();
        }
        


    }
    */
    public partial class CursoDetalle : Form
    {
        private Curso curso;
        private ErrorProvider errorProvider;

        public Curso Curso
        {
            get { return curso; }
            set
            {
                curso = value;
                this.SetCurso();
            }
        }

        public bool EditMode { get; set; } = false;

        public CursoDetalle()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            CursoApiClient client = new CursoApiClient();

            if (this.ValidateCurso())
            {
                this.Curso.IdComision = int.Parse(txtbIdComision.Text);
                this.Curso.IdMateria = int.Parse(txtbIdMateria.Text);
                this.Curso.Cupo = int.Parse(txtbCupo.Text);
                this.Curso.AnioCalendario = int.Parse(txtbAnioCalendario.Text);
                this.Curso.Descripcion = txtbDescripcion.Text;

                if (this.EditMode)
                {
                    await CursoApiClient.UpdateAsync(this.Curso);
                }
                else
                {
                    await CursoApiClient.AddAsync(this.Curso);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCurso()
        {
            this.txtbIdComision.Text = this.Curso.IdComision.ToString();
            this.txtbIdMateria.Text = this.Curso.IdMateria.ToString();
            this.txtbCupo.Text = this.Curso.Cupo.ToString();
            this.txtbAnioCalendario.Text = this.Curso.AnioCalendario.ToString();
            this.txtbDescripcion.Text = this.Curso.Descripcion;
        }

        private bool ValidateCurso()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Validar IdComision
            if (!int.TryParse(txtbIdComision.Text, out _) || int.Parse(txtbIdComision.Text) <= 0)
            {
                isValid = false;
                errorProvider.SetError(txtbIdComision, "El IdComision debe ser un número positivo.");
            }

            // Validar IdMateria
            if (!int.TryParse(txtbIdMateria.Text, out _) || int.Parse(txtbIdMateria.Text) <= 0)
            {
                isValid = false;
                errorProvider.SetError(txtbIdMateria, "El IdMateria debe ser un número positivo.");
            }

            // Validar Cupo
            if (!int.TryParse(txtbCupo.Text, out _) || int.Parse(txtbCupo.Text) <= 0)
            {
                isValid = false;
                errorProvider.SetError(txtbCupo, "El Cupo debe ser un número positivo.");
            }

            // Validar AnioCalendario
            if (!int.TryParse(txtbAnioCalendario.Text, out _) || int.Parse(txtbAnioCalendario.Text) < 2000 || int.Parse(txtbAnioCalendario.Text) > DateTime.Now.Year + 1)
            {
                isValid = false;
                errorProvider.SetError(txtbAnioCalendario, "El Año Calendario debe ser entre 2000 y el próximo año.");
            }

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