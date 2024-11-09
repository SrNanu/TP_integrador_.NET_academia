namespace Interfaz.Vistas_Cursos
{
    partial class CursoDetalle
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblPlan = new Label();
            lblIdEspecialidad = new Label();
            lblDetalles = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbCupo = new TextBox();
            txtbAnioCalendario = new TextBox();
            txtbDescripcion = new TextBox();
            cmbComisiones = new ComboBox();
            cmbMaterias = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(408, 229);
            btnAceptar.Margin = new Padding(2, 2, 2, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(78, 20);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += aceptarButton_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(303, 229);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelarButton_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(239, 5);
            lblPlan.Margin = new Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(38, 15);
            lblPlan.TabIndex = 11;
            lblPlan.Text = "Curso";
            // 
            // lblIdEspecialidad
            // 
            lblIdEspecialidad.AutoSize = true;
            lblIdEspecialidad.Location = new Point(138, 77);
            lblIdEspecialidad.Margin = new Padding(2, 0, 2, 0);
            lblIdEspecialidad.Name = "lblIdEspecialidad";
            lblIdEspecialidad.Size = new Size(57, 15);
            lblIdEspecialidad.TabIndex = 10;
            lblIdEspecialidad.Text = "IdMateria";
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Location = new Point(138, 46);
            lblDetalles.Margin = new Padding(2, 0, 2, 0);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(68, 15);
            lblDetalles.TabIndex = 8;
            lblDetalles.Text = "IdComision";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 14;
            label1.Text = "Cupo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 151);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 15;
            label2.Text = "Anio Calendario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 186);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 16;
            label3.Text = "Descripcion";
            // 
            // txtbCupo
            // 
            txtbCupo.Location = new Point(310, 111);
            txtbCupo.Margin = new Padding(2, 2, 2, 2);
            txtbCupo.Name = "txtbCupo";
            txtbCupo.Size = new Size(129, 23);
            txtbCupo.TabIndex = 17;
            // 
            // txtbAnioCalendario
            // 
            txtbAnioCalendario.Location = new Point(310, 149);
            txtbAnioCalendario.Margin = new Padding(2, 2, 2, 2);
            txtbAnioCalendario.Name = "txtbAnioCalendario";
            txtbAnioCalendario.Size = new Size(129, 23);
            txtbAnioCalendario.TabIndex = 18;
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(310, 182);
            txtbDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(129, 23);
            txtbDescripcion.TabIndex = 19;
            // 
            // cmbComisiones
            // 
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(310, 41);
            cmbComisiones.Margin = new Padding(2, 2, 2, 2);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(129, 23);
            cmbComisiones.TabIndex = 20;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(310, 77);
            cmbMaterias.Margin = new Padding(2, 2, 2, 2);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(129, 23);
            cmbMaterias.TabIndex = 21;
            // 
            // CursoDetalle
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(560, 270);
            Controls.Add(cmbMaterias);
            Controls.Add(cmbComisiones);
            Controls.Add(txtbDescripcion);
            Controls.Add(txtbAnioCalendario);
            Controls.Add(txtbCupo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPlan);
            Controls.Add(lblIdEspecialidad);
            Controls.Add(lblDetalles);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CursoDetalle";
            Text = "CursoDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblPlan;
        private Label lblIdEspecialidad;
        private Label lblDetalles;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbCupo;
        private TextBox txtbAnioCalendario;
        private TextBox txtbDescripcion;
        private ComboBox cmbComisiones;
        private ComboBox cmbMaterias;
    }
}