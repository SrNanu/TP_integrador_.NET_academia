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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 175);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Detalles";
            //comentado por error, no mergear label1.Click += this.label1_Click;
            
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 251);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 3;
            label2.Text = "Id Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 45);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 4;
            label3.Text = "Plan";
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtbDetalles);
            Name = "PlanDetalle";
            Text = "Form1";
            // comentado por error, no mergear Load += this.PlanDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbDetalles;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}