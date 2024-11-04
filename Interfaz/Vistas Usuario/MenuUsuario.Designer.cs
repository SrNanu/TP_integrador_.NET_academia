namespace Interfaz
{
    partial class MenuUsuario
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
            lblMenuUsuario = new Label();
            btnInscripcionMateria = new Button();
            SuspendLayout();
            // 
            // lblMenuUsuario
            // 
            lblMenuUsuario.AutoSize = true;
            lblMenuUsuario.Location = new Point(330, 24);
            lblMenuUsuario.Name = "lblMenuUsuario";
            lblMenuUsuario.Size = new Size(100, 20);
            lblMenuUsuario.TabIndex = 0;
            lblMenuUsuario.Text = "Menú Usuario";
            // 
            // btnInscripcionMateria
            // 
            btnInscripcionMateria.Location = new Point(119, 95);
            btnInscripcionMateria.Name = "btnInscripcionMateria";
            btnInscripcionMateria.Size = new Size(94, 55);
            btnInscripcionMateria.TabIndex = 1;
            btnInscripcionMateria.Text = "Inscribirse a materia";
            btnInscripcionMateria.UseVisualStyleBackColor = true;
            // 
            // MenuUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInscripcionMateria);
            Controls.Add(lblMenuUsuario);
            Name = "MenuUsuario";
            Text = "MenuUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuUsuario;
        private Button btnInscripcionMateria;
    }
}