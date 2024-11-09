namespace Interfaz.Vistas_Comision
{
    partial class ComisionDetalle
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
            txtbAnioEspecialidad = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblPlan = new Label();
            lblIdEspecialidad = new Label();
            txtbIdDescripcion = new TextBox();
            lblDetalles = new Label();
            cmbPlanes = new ComboBox();
            SuspendLayout();
            // 
            // txtbAnioEspecialidad
            // 
            txtbAnioEspecialidad.Location = new Point(284, 148);
            txtbAnioEspecialidad.Margin = new Padding(2, 2, 2, 2);
            txtbAnioEspecialidad.Name = "txtbAnioEspecialidad";
            txtbAnioEspecialidad.Size = new Size(129, 23);
            txtbAnioEspecialidad.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 148);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 27;
            label1.Text = "Anio Especialidad";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(376, 236);
            btnAceptar.Margin = new Padding(2, 2, 2, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(78, 20);
            btnAceptar.TabIndex = 26;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += aceptarButton_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(271, 236);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelarButton_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(222, 32);
            lblPlan.Margin = new Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(58, 15);
            lblPlan.TabIndex = 24;
            lblPlan.Text = "Comision";
            // 
            // lblIdEspecialidad
            // 
            lblIdEspecialidad.AutoSize = true;
            lblIdEspecialidad.Location = new Point(111, 115);
            lblIdEspecialidad.Margin = new Padding(2, 0, 2, 0);
            lblIdEspecialidad.Name = "lblIdEspecialidad";
            lblIdEspecialidad.Size = new Size(69, 15);
            lblIdEspecialidad.TabIndex = 23;
            lblIdEspecialidad.Text = "Descripcion";
            // 
            // txtbIdDescripcion
            // 
            txtbIdDescripcion.Location = new Point(284, 115);
            txtbIdDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtbIdDescripcion.Name = "txtbIdDescripcion";
            txtbIdDescripcion.Size = new Size(129, 23);
            txtbIdDescripcion.TabIndex = 22;
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Location = new Point(111, 83);
            lblDetalles.Margin = new Padding(2, 0, 2, 0);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(30, 15);
            lblDetalles.TabIndex = 21;
            lblDetalles.Text = "Plan";
            // 
            // cmbPlanes
            // 
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(284, 78);
            cmbPlanes.Margin = new Padding(2, 2, 2, 2);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(129, 23);
            cmbPlanes.TabIndex = 31;
            // 
            // ComisionDetalle
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(560, 270);
            Controls.Add(cmbPlanes);
            Controls.Add(txtbAnioEspecialidad);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPlan);
            Controls.Add(lblIdEspecialidad);
            Controls.Add(txtbIdDescripcion);
            Controls.Add(lblDetalles);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ComisionDetalle";
            Text = "ComisionDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtbAnioEspecialidad;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblPlan;
        private Label lblIdEspecialidad;
        private TextBox txtbIdDescripcion;
        private Label lblDetalles;
        private ComboBox cmbPlanes;
    }
}