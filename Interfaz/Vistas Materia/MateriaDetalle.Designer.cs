namespace Interfaz.Vistas_Materia
{
    partial class MateriaDetalle
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
            lblDescripcion = new Label();
            txtbDescripcion = new TextBox();
            label1 = new Label();
            lblIdPlan = new Label();
            txtbHsSemanales = new TextBox();
            lblHsSemanales = new Label();
            txtbHsTotales = new TextBox();
            HsTotales = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            cmbPlanes = new ComboBox();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(118, 42);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(246, 42);
            txtbDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(129, 23);
            txtbDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 90);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // lblIdPlan
            // 
            lblIdPlan.AutoSize = true;
            lblIdPlan.Location = new Point(118, 88);
            lblIdPlan.Margin = new Padding(2, 0, 2, 0);
            lblIdPlan.Name = "lblIdPlan";
            lblIdPlan.Size = new Size(30, 15);
            lblIdPlan.TabIndex = 3;
            lblIdPlan.Text = "Plan";
            // 
            // txtbHsSemanales
            // 
            txtbHsSemanales.Location = new Point(246, 126);
            txtbHsSemanales.Margin = new Padding(2, 2, 2, 2);
            txtbHsSemanales.Name = "txtbHsSemanales";
            txtbHsSemanales.Size = new Size(129, 23);
            txtbHsSemanales.TabIndex = 6;
            // 
            // lblHsSemanales
            // 
            lblHsSemanales.AutoSize = true;
            lblHsSemanales.Location = new Point(118, 128);
            lblHsSemanales.Margin = new Padding(2, 0, 2, 0);
            lblHsSemanales.Name = "lblHsSemanales";
            lblHsSemanales.Size = new Size(97, 15);
            lblHsSemanales.TabIndex = 5;
            lblHsSemanales.Text = "Horas Semanales";
            // 
            // txtbHsTotales
            // 
            txtbHsTotales.Location = new Point(246, 164);
            txtbHsTotales.Margin = new Padding(2, 2, 2, 2);
            txtbHsTotales.Name = "txtbHsTotales";
            txtbHsTotales.Size = new Size(129, 23);
            txtbHsTotales.TabIndex = 8;
            // 
            // HsTotales
            // 
            HsTotales.AutoSize = true;
            HsTotales.Location = new Point(118, 166);
            HsTotales.Margin = new Padding(2, 0, 2, 0);
            HsTotales.Name = "HsTotales";
            HsTotales.Size = new Size(77, 15);
            HsTotales.TabIndex = 7;
            HsTotales.Text = "Horas Totales";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(440, 227);
            btnConfirmar.Margin = new Padding(2, 2, 2, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(78, 20);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += aceptarButton_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(323, 227);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelarButton_Click;
            // 
            // cmbPlanes
            // 
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(246, 83);
            cmbPlanes.Margin = new Padding(2, 2, 2, 2);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(129, 23);
            cmbPlanes.TabIndex = 11;
            // 
            // MateriaDetalle
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(560, 270);
            Controls.Add(cmbPlanes);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtbHsTotales);
            Controls.Add(HsTotales);
            Controls.Add(txtbHsSemanales);
            Controls.Add(lblHsSemanales);
            Controls.Add(lblIdPlan);
            Controls.Add(label1);
            Controls.Add(txtbDescripcion);
            Controls.Add(lblDescripcion);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MateriaDetalle";
            Text = "MateriaDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private TextBox txtbDescripcion;
        private Label label1;
        private Label lblIdPlan;
        private TextBox txtbHsSemanales;
        private Label lblHsSemanales;
        private TextBox txtbHsTotales;
        private Label HsTotales;
        private Button btnConfirmar;
        private Button btnCancelar;
        private ComboBox cmbPlanes;
    }
}