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
            btnOlvideContrasenia = new Button();
            btnCrearUsuario = new Button();
            lblAcademia = new Label();
            SuspendLayout();
            // 
            // txtbContrasenia
            // 
            txtbContrasenia.Location = new Point(429, 327);
            txtbContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtbContrasenia.Name = "txtbContrasenia";
            txtbContrasenia.Size = new Size(141, 31);
            txtbContrasenia.TabIndex = 15;
            // 
            // txtbUsuario
            // 
            txtbUsuario.Location = new Point(429, 167);
            txtbUsuario.Margin = new Padding(4, 5, 4, 5);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.Size = new Size(141, 31);
            txtbUsuario.TabIndex = 14;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.HotTrack;
            btnIniciarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnIniciarSesion.Location = new Point(407, 452);
            btnIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(173, 38);
            btnIniciarSesion.TabIndex = 13;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(244, 327);
            lblContrasenia.Margin = new Padding(4, 0, 4, 0);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(101, 25);
            lblContrasenia.TabIndex = 12;
            lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(244, 177);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // btnOlvideContrasenia
            // 
            btnOlvideContrasenia.BackColor = SystemColors.Info;
            btnOlvideContrasenia.Location = new Point(244, 692);
            btnOlvideContrasenia.Margin = new Padding(4, 5, 4, 5);
            btnOlvideContrasenia.Name = "btnOlvideContrasenia";
            btnOlvideContrasenia.Size = new Size(216, 38);
            btnOlvideContrasenia.TabIndex = 10;
            btnOlvideContrasenia.Text = "Olvide mi contraseña";
            btnOlvideContrasenia.UseVisualStyleBackColor = false;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = SystemColors.Info;
            btnCrearUsuario.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearUsuario.Location = new Point(16, 692);
            btnCrearUsuario.Margin = new Padding(4, 5, 4, 5);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(191, 38);
            btnCrearUsuario.TabIndex = 9;
            btnCrearUsuario.Text = "Crear usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            // 
            // lblAcademia
            // 
            lblAcademia.AutoSize = true;
            lblAcademia.Location = new Point(447, 58);
            lblAcademia.Margin = new Padding(4, 0, 4, 0);
            lblAcademia.Name = "lblAcademia";
            lblAcademia.Size = new Size(102, 25);
            lblAcademia.TabIndex = 8;
            lblAcademia.Text = "ACADEMIA";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(txtbContrasenia);
            Controls.Add(txtbUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(btnOlvideContrasenia);
            Controls.Add(btnCrearUsuario);
            Controls.Add(lblAcademia);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnOlvideContrasenia;
        private Button btnCrearUsuario;
        private Label lblAcademia;
    }
}