namespace Interfaz.Vistas_Plan
{
    partial class PlanDetalle
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

            txtbDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblEspecialidad = new Label();
            lblPlan = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cmbEspecialidades = new ComboBox();
            SuspendLayout();
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(230, 105);
            txtbDescripcion.Margin = new Padding(2);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(129, 23);
            txtbDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(128, 105);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(121, 151);
            lblEspecialidad.Margin = new Padding(2, 0, 2, 0);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(72, 15);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidad";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(230, 27);
            lblPlan.Margin = new Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 4;
            lblPlan.Text = "Plan";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(350, 235);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelarButton_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(455, 235);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(78, 20);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += aceptarButton_Click;
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.Location = new Point(230, 151);
            cmbEspecialidades.Margin = new Padding(2);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(129, 23);
            cmbEspecialidades.TabIndex = 7;
            // 
            // PlanDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(cmbEspecialidades);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPlan);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblDescripcion);
            Controls.Add(txtbDescripcion);
            Margin = new Padding(2);
            Name = "PlanDetalle";
            Text = "Plan Detalle";
            Load += PlanDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbDescripcion;
        private Label lblDescripcion;
        private Label lblEspecialidad;
        private Label lblPlan;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cmbEspecialidades;
    }
}