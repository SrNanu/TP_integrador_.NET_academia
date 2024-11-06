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
            txtbIdMateria = new TextBox();
            lblDetalles = new Label();
            txtbIdComision = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbCupo = new TextBox();
            txtbAnioCalendario = new TextBox();
            txtbDescripcion = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(583, 381);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += aceptarButton_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(433, 381);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelarButton_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(342, 9);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(58, 25);
            lblPlan.TabIndex = 11;
            lblPlan.Text = "Curso";
            // 
            // lblIdEspecialidad
            // 
            lblIdEspecialidad.AutoSize = true;
            lblIdEspecialidad.Location = new Point(197, 129);
            lblIdEspecialidad.Name = "lblIdEspecialidad";
            lblIdEspecialidad.Size = new Size(87, 25);
            lblIdEspecialidad.TabIndex = 10;
            lblIdEspecialidad.Text = "IdMateria";
            // 
            // txtbIdMateria
            // 
            txtbIdMateria.Location = new Point(443, 129);
            txtbIdMateria.Name = "txtbIdMateria";
            txtbIdMateria.Size = new Size(150, 31);
            txtbIdMateria.TabIndex = 9;
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Location = new Point(197, 76);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(103, 25);
            lblDetalles.TabIndex = 8;
            lblDetalles.Text = "IdComision";
            // 
            // txtbIdComision
            // 
            txtbIdComision.Location = new Point(443, 73);
            txtbIdComision.Name = "txtbIdComision";
            txtbIdComision.Size = new Size(150, 31);
            txtbIdComision.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 185);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 14;
            label1.Text = "Cupo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 252);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 15;
            label2.Text = "Anio Calendario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 310);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 16;
            label3.Text = "Descripcion";
            // 
            // txtbCupo
            // 
            txtbCupo.Location = new Point(443, 185);
            txtbCupo.Name = "txtbCupo";
            txtbCupo.Size = new Size(150, 31);
            txtbCupo.TabIndex = 17;
            // 
            // txtbAnioCalendario
            // 
            txtbAnioCalendario.Location = new Point(443, 249);
            txtbAnioCalendario.Name = "txtbAnioCalendario";
            txtbAnioCalendario.Size = new Size(150, 31);
            txtbAnioCalendario.TabIndex = 18;
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(443, 304);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(150, 31);
            txtbDescripcion.TabIndex = 19;
            // 
            // CursoDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(txtbIdMateria);
            Controls.Add(lblDetalles);
            Controls.Add(txtbIdComision);
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
        private TextBox txtbIdMateria;
        private Label lblDetalles;
        private TextBox txtbIdComision;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbCupo;
        private TextBox txtbAnioCalendario;
        private TextBox txtbDescripcion;
    }
}