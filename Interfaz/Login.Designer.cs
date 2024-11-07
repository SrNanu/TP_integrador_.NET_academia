namespace Interfaz
{
    partial class Login
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
            txtbContrasenia = new TextBox();
            txtbUsuario = new TextBox();
            btnIniciarSesion = new Button();
            lblContrasenia = new Label();
            lblUsuario = new Label();
            btnRegistrarse = new Button();
            lblAcademia = new Label();
            SuspendLayout();
            // 
            // txtbContrasenia
            // 
            txtbContrasenia.Location = new Point(300, 196);
            txtbContrasenia.Name = "txtbContrasenia";
            txtbContrasenia.Size = new Size(100, 23);
            txtbContrasenia.TabIndex = 15;
            // 
            // txtbUsuario
            // 
            txtbUsuario.Location = new Point(300, 100);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.Size = new Size(100, 23);
            txtbUsuario.TabIndex = 14;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.HotTrack;
            btnIniciarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnIniciarSesion.Location = new Point(285, 271);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(121, 23);
            btnIniciarSesion.TabIndex = 13;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += IniciarSesion;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(171, 196);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 12;
            lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(171, 106);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = SystemColors.Info;
            btnRegistrarse.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrarse.Location = new Point(11, 414);
            btnRegistrarse.Margin = new Padding(2, 2, 2, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(94, 25);
            btnRegistrarse.TabIndex = 9;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += Registarse;
            // 
            // lblAcademia
            // 
            lblAcademia.AutoSize = true;
            lblAcademia.Location = new Point(313, 35);
            lblAcademia.Name = "lblAcademia";
            lblAcademia.Size = new Size(67, 15);
            lblAcademia.TabIndex = 8;
            lblAcademia.Text = "ACADEMIA";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbContrasenia);
            Controls.Add(txtbUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(btnRegistrarse);
            Controls.Add(lblAcademia);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbContrasenia;
        private TextBox txtbUsuario;
        private Button btnIniciarSesion;
        private Label lblContrasenia;
        private Label lblUsuario;
        private Button btnRegistrarse;
        private Label lblAcademia;
    }
}