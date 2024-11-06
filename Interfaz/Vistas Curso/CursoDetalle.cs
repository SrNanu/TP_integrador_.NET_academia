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
            LoadComisiones(); // Cargar comisiones al iniciar el formulario
            LoadMaterias();   // Cargar materias al iniciar el formulario
        }
        private async void LoadComisiones()
        {
            // Llama al API o a la base de datos para obtener la lista de comisiones
            List<Comision> comisiones = (List<Comision>)await ComisionApiClient.GetAllAsync();

            cmbComisiones.DataSource = comisiones;
            cmbComisiones.DisplayMember = "Descripcion"; // Mostrar la descripción de la comisión
            cmbComisiones.ValueMember = "Id"; // El valor será el Id de la comisión
        }

        private async void LoadMaterias()
        {
            // Llama al API o a la base de datos para obtener la lista de materias
            List<Materia> materias = (List<Materia>)await MateriaApiClient.GetAllAsync();

            cmbMaterias.DataSource = materias;
            cmbMaterias.DisplayMember = "Descripcion"; // Mostrar la descripción de la materia
            cmbMaterias.ValueMember = "Id"; // El valor será el Id de la materia
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            CursoApiClient client = new CursoApiClient();

            if (this.ValidateCurso())
            {
                // Guardar el Id de la comisión y la materia seleccionada
                this.Curso.IdComision = (int)cmbComisiones.SelectedValue;
                this.Curso.IdMateria = (int)cmbMaterias.SelectedValue;

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
            this.txtbCupo.Text = this.Curso.Cupo.ToString();
            this.txtbAnioCalendario.Text = this.Curso.AnioCalendario.ToString();
            this.txtbDescripcion.Text = this.Curso.Descripcion;

            if (Curso != null)
            {
                cmbComisiones.SelectedValue = this.Curso.IdComision;
                cmbMaterias.SelectedValue = this.Curso.IdMateria;
            }
        }

        private bool ValidateCurso()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (cmbComisiones.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cmbComisiones, "Debe seleccionar una Comisión.");
            }

            if (cmbMaterias.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cmbMaterias, "Debe seleccionar una Materia.");
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