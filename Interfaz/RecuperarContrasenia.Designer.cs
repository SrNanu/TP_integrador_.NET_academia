namespace Interfaz
{
    partial class RecuperarContrasenia
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
            lblRecuperoContrasenia = new Label();
            rtbAvisoComportamiento = new RichTextBox();
            lblApellido = new Label();
            lblNombreUsuario = new Label();
            lblEmail = new Label();
            lblLegajo = new Label();
            lblFechaNacimiento = new Label();
            txtbApellido = new TextBox();
            txtbUsuario = new TextBox();
            txtbEmail = new TextBox();
            txtbLegajo = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnRecuperar = new Button();
            btnCancelar = new Button();
            lblDarContra = new Label();
            txtbDarContra = new TextBox();
            SuspendLayout();
            // 
            // lblRecuperoContrasenia
            // 
            lblRecuperoContrasenia.AutoSize = true;
            lblRecuperoContrasenia.Location = new Point(274, 9);
            lblRecuperoContrasenia.Name = "lblRecuperoContrasenia";
            lblRecuperoContrasenia.Size = new Size(189, 15);
            lblRecuperoContrasenia.TabIndex = 0;
            lblRecuperoContrasenia.Text = "RECUPERACIÓN DE CONTRASEÑA";
            // 
            // rtbAvisoComportamiento
            // 
            rtbAvisoComportamiento.Location = new Point(41, 41);
            rtbAvisoComportamiento.Name = "rtbAvisoComportamiento";
            rtbAvisoComportamiento.ReadOnly = true;
            rtbAvisoComportamiento.Size = new Size(683, 42);
            rtbAvisoComportamiento.TabIndex = 1;
            rtbAvisoComportamiento.Text = "El sistema le mostrará la contraseña al usuario si los datos de los campos a completar coinciden con los datos de un usuario en particular.";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(47, 109);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(47, 144);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(109, 15);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(47, 179);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(48, 214);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 5;
            lblLegajo.Text = "Legajo";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(47, 246);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(117, 15);
            lblFechaNacimiento.TabIndex = 6;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // txtbApellido
            // 
            txtbApellido.Location = new Point(299, 101);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(100, 23);
            txtbApellido.TabIndex = 7;
            // 
            // txtbUsuario
            // 
            txtbUsuario.Location = new Point(299, 141);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.Size = new Size(100, 23);
            txtbUsuario.TabIndex = 8;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(299, 180);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(100, 23);
            txtbEmail.TabIndex = 9;
            // 
            // txtbLegajo
            // 
            txtbLegajo.Location = new Point(299, 211);
            txtbLegajo.Name = "txtbLegajo";
            txtbLegajo.Size = new Size(100, 23);
            txtbLegajo.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(299, 246);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(287, 294);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(75, 23);
            btnRecuperar.TabIndex = 12;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(704, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDarContra
            // 
            lblDarContra.AutoSize = true;
            lblDarContra.Location = new Point(217, 332);
            lblDarContra.Name = "lblDarContra";
            lblDarContra.Size = new Size(98, 15);
            lblDarContra.TabIndex = 14;
            lblDarContra.Text = "Su contraseña es:";
            lblDarContra.Visible = false;
            // 
            // txtbDarContra
            // 
            txtbDarContra.Location = new Point(353, 329);
            txtbDarContra.Name = "txtbDarContra";
            txtbDarContra.ReadOnly = true;
            txtbDarContra.Size = new Size(100, 23);
            txtbDarContra.TabIndex = 15;
            txtbDarContra.Visible = false;
            // 
            // RecuperarContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbDarContra);
            Controls.Add(lblDarContra);
            Controls.Add(btnCancelar);
            Controls.Add(btnRecuperar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtbLegajo);
            Controls.Add(txtbEmail);
            Controls.Add(txtbUsuario);
            Controls.Add(txtbApellido);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblLegajo);
            Controls.Add(lblEmail);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblApellido);
            Controls.Add(rtbAvisoComportamiento);
            Controls.Add(lblRecuperoContrasenia);
            Name = "RecuperarContrasenia";
            Text = "RecuperarContrasenia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecuperoContrasenia;
        private RichTextBox rtbAvisoComportamiento;
        private Label lblApellido;
        private Label lblNombreUsuario;
        private Label lblEmail;
        private Label lblLegajo;
        private Label lblFechaNacimiento;
        private TextBox txtbApellido;
        private TextBox txtbUsuario;
        private TextBox txtbEmail;
        private TextBox txtbLegajo;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnRecuperar;
        private Button btnCancelar;
        private Label lblDarContra;
        private TextBox txtbDarContra;
    }
}