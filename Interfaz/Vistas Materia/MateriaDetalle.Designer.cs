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
            txtbIdPlan = new TextBox();
            lblIdPlan = new Label();
            txtbHsSemanales = new TextBox();
            lblHsSemanales = new Label();
            txtbHsTotales = new TextBox();
            HsTotales = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(169, 70);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 25);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtbDescripcion
            // 
            txtbDescripcion.Location = new Point(352, 70);
            txtbDescripcion.Name = "txtbDescripcion";
            txtbDescripcion.Size = new Size(150, 31);
            txtbDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 150);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // txtbIdPlan
            // 
            txtbIdPlan.Location = new Point(352, 141);
            txtbIdPlan.Name = "txtbIdPlan";
            txtbIdPlan.Size = new Size(150, 31);
            txtbIdPlan.TabIndex = 4;
            // 
            // lblIdPlan
            // 
            lblIdPlan.AutoSize = true;
            lblIdPlan.Location = new Point(169, 147);
            lblIdPlan.Name = "lblIdPlan";
            lblIdPlan.Size = new Size(66, 25);
            lblIdPlan.TabIndex = 3;
            lblIdPlan.Text = "Id Plan";
            // 
            // txtbHsSemanales
            // 
            txtbHsSemanales.Location = new Point(352, 210);
            txtbHsSemanales.Name = "txtbHsSemanales";
            txtbHsSemanales.Size = new Size(150, 31);
            txtbHsSemanales.TabIndex = 6;
            // 
            // lblHsSemanales
            // 
            lblHsSemanales.AutoSize = true;
            lblHsSemanales.Location = new Point(169, 213);
            lblHsSemanales.Name = "lblHsSemanales";
            lblHsSemanales.Size = new Size(148, 25);
            lblHsSemanales.TabIndex = 5;
            lblHsSemanales.Text = "Horas Semanales";
            // 
            // txtbHsTotales
            // 
            txtbHsTotales.Location = new Point(352, 273);
            txtbHsTotales.Name = "txtbHsTotales";
            txtbHsTotales.Size = new Size(150, 31);
            txtbHsTotales.TabIndex = 8;
            // 
            // HsTotales
            // 
            HsTotales.AutoSize = true;
            HsTotales.Location = new Point(169, 276);
            HsTotales.Name = "HsTotales";
            HsTotales.Size = new Size(118, 25);
            HsTotales.TabIndex = 7;
            HsTotales.Text = "Horas Totales";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(628, 378);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += aceptarButton_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(462, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelarButton_Click;
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtbHsTotales);
            Controls.Add(HsTotales);
            Controls.Add(txtbHsSemanales);
            Controls.Add(lblHsSemanales);
            Controls.Add(txtbIdPlan);
            Controls.Add(lblIdPlan);
            Controls.Add(label1);
            Controls.Add(txtbDescripcion);
            Controls.Add(lblDescripcion);
            Name = "MateriaDetalle";
            Text = "MateriaDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private TextBox txtbDescripcion;
        private Label label1;
        private TextBox txtbIdPlan;
        private Label lblIdPlan;
        private TextBox txtbHsSemanales;
        private Label lblHsSemanales;
        private TextBox txtbHsTotales;
        private Label HsTotales;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}