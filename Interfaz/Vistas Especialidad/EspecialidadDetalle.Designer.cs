namespace Interfaz.Vistas_Especialidad
{
    partial class EspecialidadDetalle
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
            lblDescripcion = new Label();
            txtbDescripcion = new TextBox();
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
            lblPlan.Location = new Point(225, 26);
            lblPlan.Margin = new Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(72, 15);
            lblPlan.TabIndex = 11;
            lblPlan.Text = "Especialidad";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(116, 101);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(213, 99);
            txtbDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(106, 23);
            txtbDescripcion.TabIndex = 7;
            // 
            // EspecialidadDetalle
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(560, 270);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPlan);
            Controls.Add(lblDescripcion);
            Controls.Add(txtbDescripcion);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EspecialidadDetalle";
            Text = "EspecialidadDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblPlan;
        private Label lblDescripcion;
        private TextBox txtbDescripcion;
    }
}