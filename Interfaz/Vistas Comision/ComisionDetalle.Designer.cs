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
            txtbAnioEspecialidad.Location = new Point(405, 247);
            txtbAnioEspecialidad.Name = "txtbAnioEspecialidad";
            txtbAnioEspecialidad.Size = new Size(182, 31);
            txtbAnioEspecialidad.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 247);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 27;
            label1.Text = "Anio Especialidad";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(537, 394);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 26;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += aceptarButton_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(387, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelarButton_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(317, 54);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(87, 25);
            lblPlan.TabIndex = 24;
            lblPlan.Text = "Comision";
            // 
            // lblIdEspecialidad
            // 
            lblIdEspecialidad.AutoSize = true;
            lblIdEspecialidad.Location = new Point(159, 191);
            lblIdEspecialidad.Name = "lblIdEspecialidad";
            lblIdEspecialidad.Size = new Size(104, 25);
            lblIdEspecialidad.TabIndex = 23;
            lblIdEspecialidad.Text = "Descripcion";
            // 
            // txtbIdDescripcion
            // 
            txtbIdDescripcion.Location = new Point(405, 191);
            txtbIdDescripcion.Name = "txtbIdDescripcion";
            txtbIdDescripcion.Size = new Size(182, 31);
            txtbIdDescripcion.TabIndex = 22;
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Location = new Point(159, 138);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(45, 25);
            lblDetalles.TabIndex = 21;
            lblDetalles.Text = "Plan";
            // 
            // cmbPlanes
            // 
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(405, 130);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(182, 33);
            cmbPlanes.TabIndex = 31;
            // 
            // ComisionDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPlanes);
            Controls.Add(txtbAnioEspecialidad);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPlan);
            Controls.Add(lblIdEspecialidad);
            Controls.Add(txtbIdDescripcion);
            Controls.Add(lblDetalles);
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