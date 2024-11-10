namespace Interfaz
{
    partial class MenuAlumnos
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
            lknLogOut = new LinkLabel();
            SuspendLayout();
            // 
            // lblMenuUsuario
            // 
            lblMenuUsuario.AutoSize = true;
            lblMenuUsuario.Location = new Point(289, 18);
            lblMenuUsuario.Name = "lblMenuUsuario";
            lblMenuUsuario.Size = new Size(81, 15);
            lblMenuUsuario.TabIndex = 0;
            lblMenuUsuario.Text = "Menú Usuario";
            // 
            // btnInscripcionMateria
            // 
            btnInscripcionMateria.Location = new Point(104, 71);
            btnInscripcionMateria.Margin = new Padding(3, 2, 3, 2);
            btnInscripcionMateria.Name = "btnInscripcionMateria";
            btnInscripcionMateria.Size = new Size(148, 56);
            btnInscripcionMateria.TabIndex = 1;
            btnInscripcionMateria.Text = "Inscribirse a Curso";
            btnInscripcionMateria.UseVisualStyleBackColor = true;
            btnInscripcionMateria.Click += btnInscripcionMateria_Click;
            // 
            // lknLogOut
            // 
            lknLogOut.AutoSize = true;
            lknLogOut.Location = new Point(38, 302);
            lknLogOut.Name = "lknLogOut";
            lknLogOut.Size = new Size(47, 15);
            lknLogOut.TabIndex = 2;
            lknLogOut.TabStop = true;
            lknLogOut.Text = "LogOut";
            lknLogOut.Click += lknLogOut_Click;
            // 
            // MenuAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lknLogOut);
            Controls.Add(btnInscripcionMateria);
            Controls.Add(lblMenuUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuAlumnos";
            Text = "MenuUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuUsuario;
        private Button btnInscripcionMateria;
        private LinkLabel lknLogOut;
    }
}