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
            txtbDetalles = new TextBox();
            lblDetalles = new Label();
            txtbIdEspecialidad = new TextBox();
            lblIdEspecialidad = new Label();
            lblPlan = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtbDetalles
            // 
            txtbDetalles.Location = new Point(328, 175);
            txtbDetalles.Name = "txtbDetalles";
            txtbDetalles.Size = new Size(150, 31);
            txtbDetalles.TabIndex = 0;
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.Location = new Point(183, 175);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(74, 25);
            lblDetalles.TabIndex = 1;
            lblDetalles.Text = "Detalles";
            // 
            // txtbIdEspecialidad
            // 
            txtbIdEspecialidad.Location = new Point(328, 251);
            txtbIdEspecialidad.Name = "txtbIdEspecialidad";
            txtbIdEspecialidad.Size = new Size(150, 31);
            txtbIdEspecialidad.TabIndex = 2;
            // 
            // lblIdEspecialidad
            // 
            lblIdEspecialidad.AutoSize = true;
            lblIdEspecialidad.Location = new Point(173, 251);
            lblIdEspecialidad.Name = "lblIdEspecialidad";
            lblIdEspecialidad.Size = new Size(130, 25);
            lblIdEspecialidad.TabIndex = 3;
            lblIdEspecialidad.Text = "Id Especialidad";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(328, 45);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(45, 25);
            lblPlan.TabIndex = 4;
            lblPlan.Text = "Plan";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(500, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(650, 391);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // PlanDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPlan);
            Controls.Add(lblIdEspecialidad);
            Controls.Add(txtbIdEspecialidad);
            Controls.Add(lblDetalles);
            Controls.Add(txtbDetalles);
            Name = "PlanDetalle";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbDetalles;
        private Label lblDetalles;
        private TextBox txtbIdEspecialidad;
        private Label lblIdEspecialidad;
        private Label lblPlan;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}