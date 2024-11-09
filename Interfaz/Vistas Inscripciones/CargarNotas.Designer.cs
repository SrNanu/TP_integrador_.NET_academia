namespace Interfaz.Vistas_Inscripciones
{
    partial class CargarNota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtbIDAlumno = new TextBox();
            txtbIDCurso = new TextBox();
            lblIdAlumno = new Label();
            lblIdCurso = new Label();
            lblInstruccion = new Label();
            lblNota = new Label();
            txtbNota = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(332, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cargado De Notas";
            // 
            // txtbIDAlumno
            // 
            txtbIDAlumno.Location = new Point(133, 96);
            txtbIDAlumno.Name = "txtbIDAlumno";
            txtbIDAlumno.Size = new Size(186, 23);
            txtbIDAlumno.TabIndex = 1;
            // 
            // txtbIDCurso
            // 
            txtbIDCurso.Location = new Point(133, 157);
            txtbIDCurso.Name = "txtbIDCurso";
            txtbIDCurso.Size = new Size(184, 23);
            txtbIDCurso.TabIndex = 2;
            // 
            // lblIdAlumno
            // 
            lblIdAlumno.AutoSize = true;
            lblIdAlumno.Location = new Point(48, 99);
            lblIdAlumno.Name = "lblIdAlumno";
            lblIdAlumno.Size = new Size(64, 15);
            lblIdAlumno.TabIndex = 3;
            lblIdAlumno.Text = "ID Alumno";
            // 
            // lblIdCurso
            // 
            lblIdCurso.AutoSize = true;
            lblIdCurso.Location = new Point(60, 160);
            lblIdCurso.Name = "lblIdCurso";
            lblIdCurso.Size = new Size(52, 15);
            lblIdCurso.TabIndex = 4;
            lblIdCurso.Text = "ID Curso";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(102, 51);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(48, 15);
            lblInstruccion.TabIndex = 5;
            lblInstruccion.Text = "Ingrese:";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(403, 126);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(160, 15);
            lblNota.TabIndex = 6;
            lblNota.Text = "Ingrese la Nota de el Alumno";
            // 
            // txtbNota
            // 
            txtbNota.Location = new Point(585, 123);
            txtbNota.Name = "txtbNota";
            txtbNota.Size = new Size(100, 23);
            txtbNota.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(540, 395);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(665, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CargarNota
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtbNota);
            Controls.Add(lblNota);
            Controls.Add(lblInstruccion);
            Controls.Add(lblIdCurso);
            Controls.Add(lblIdAlumno);
            Controls.Add(txtbIDCurso);
            Controls.Add(txtbIDAlumno);
            Controls.Add(lblTitulo);
            Name = "CargarNota";
            Text = "Cargar Nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtbIDAlumno;
        private TextBox txtbIDCurso;
        private Label lblIdAlumno;
        private Label lblIdCurso;
        private Label lblInstruccion;
        private Label lblNota;
        private TextBox txtbNota;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}