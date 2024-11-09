namespace Interfaz.Vistas_Inscripciones
{
    partial class InscripcionCurso
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
            lblIdCurso = new Label();
            txtbIDCurso = new TextBox();
            lblInstrucciones = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(596, 398);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(697, 398);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblIdCurso
            // 
            lblIdCurso.AutoSize = true;
            lblIdCurso.Location = new Point(84, 174);
            lblIdCurso.Name = "lblIdCurso";
            lblIdCurso.Size = new Size(52, 15);
            lblIdCurso.TabIndex = 3;
            lblIdCurso.Text = "ID Curso";
            // 
            // txtbIDCurso
            // 
            txtbIDCurso.Location = new Point(166, 171);
            txtbIDCurso.Name = "txtbIDCurso";
            txtbIDCurso.Size = new Size(180, 23);
            txtbIDCurso.TabIndex = 5;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Location = new Point(79, 126);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(253, 15);
            lblInstrucciones.TabIndex = 6;
            lblInstrucciones.Text = "Ingrese el Id del Curso al que se quiere inscribir";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(337, 57);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 15);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Inscribirse a un Curso";
            // 
            // InscripcionCurso
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblInstrucciones);
            Controls.Add(txtbIDCurso);
            Controls.Add(lblIdCurso);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "InscripcionCurso";
            Text = "Inscribirse a un Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblIdCurso;
        private TextBox txtbIDCurso;
        private Label lblInstrucciones;
        private Label lblTitulo;
    }
}