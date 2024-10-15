namespace Interfaz
{
    partial class CrearUsuario
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
            lblCrearNuevoUsuario = new Label();
            lblDatosPersonales = new Label();
            lblDatosCuenta = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblFechaNacimiento = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            lblTipoUsuarios = new Label();
            cbAlumno = new CheckBox();
            cbProfesor = new CheckBox();
            cbAdministrativo = new CheckBox();
            txtbNombre = new TextBox();
            txtbApellido = new TextBox();
            txtbUsuario = new TextBox();
            txtbContrasenia = new TextBox();
            txtbDireccion = new TextBox();
            txtbTelefono = new TextBox();
            txtbEmail = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblCrearNuevoUsuario
            // 
            lblCrearNuevoUsuario.AutoSize = true;
            lblCrearNuevoUsuario.Location = new Point(317, 29);
            lblCrearNuevoUsuario.Name = "lblCrearNuevoUsuario";
            lblCrearNuevoUsuario.Size = new Size(137, 15);
            lblCrearNuevoUsuario.TabIndex = 0;
            lblCrearNuevoUsuario.Text = "CREAR NUEVO USUARIO";
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.Location = new Point(90, 59);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(96, 15);
            lblDatosPersonales.TabIndex = 1;
            lblDatosPersonales.Text = "Datos personales";
            // 
            // lblDatosCuenta
            // 
            lblDatosCuenta.AutoSize = true;
            lblDatosCuenta.Location = new Point(626, 59);
            lblDatosCuenta.Name = "lblDatosCuenta";
            lblDatosCuenta.Size = new Size(92, 15);
            lblDatosCuenta.TabIndex = 2;
            lblDatosCuenta.Text = "Datos de cuenta";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(20, 158);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(21, 201);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(117, 15);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(22, 245);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(22, 286);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 327);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(504, 113);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(504, 187);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 10;
            lblContrasenia.Text = "Contraseña";
            // 
            // lblTipoUsuarios
            // 
            lblTipoUsuarios.AutoSize = true;
            lblTipoUsuarios.Location = new Point(504, 245);
            lblTipoUsuarios.Name = "lblTipoUsuarios";
            lblTipoUsuarios.Size = new Size(88, 15);
            lblTipoUsuarios.TabIndex = 11;
            lblTipoUsuarios.Text = "Tipo de usuario";
            // 
            // cbAlumno
            // 
            cbAlumno.AutoSize = true;
            cbAlumno.Location = new Point(629, 246);
            cbAlumno.Name = "cbAlumno";
            cbAlumno.Size = new Size(69, 19);
            cbAlumno.TabIndex = 12;
            cbAlumno.Text = "Alumno";
            cbAlumno.UseVisualStyleBackColor = true;
            // 
            // cbProfesor
            // 
            cbProfesor.AutoSize = true;
            cbProfesor.Location = new Point(628, 274);
            cbProfesor.Name = "cbProfesor";
            cbProfesor.Size = new Size(70, 19);
            cbProfesor.TabIndex = 13;
            cbProfesor.Text = "Profesor";
            cbProfesor.UseVisualStyleBackColor = true;
            // 
            // cbAdministrativo
            // 
            cbAdministrativo.AutoSize = true;
            cbAdministrativo.Location = new Point(628, 303);
            cbAdministrativo.Name = "cbAdministrativo";
            cbAdministrativo.Size = new Size(104, 19);
            cbAdministrativo.TabIndex = 14;
            cbAdministrativo.Text = "Administrativo";
            cbAdministrativo.UseVisualStyleBackColor = true;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(150, 111);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(100, 23);
            txtbNombre.TabIndex = 15;
            // 
            // txtbApellido
            // 
            txtbApellido.Location = new Point(150, 158);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(100, 23);
            txtbApellido.TabIndex = 16;
            // 
            // txtbUsuario
            // 
            txtbUsuario.Location = new Point(618, 110);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.Size = new Size(100, 23);
            txtbUsuario.TabIndex = 17;
            // 
            // txtbContrasenia
            // 
            txtbContrasenia.Location = new Point(618, 179);
            txtbContrasenia.Name = "txtbContrasenia";
            txtbContrasenia.Size = new Size(100, 23);
            txtbContrasenia.TabIndex = 18;
            // 
            // txtbDireccion
            // 
            txtbDireccion.Location = new Point(150, 245);
            txtbDireccion.Name = "txtbDireccion";
            txtbDireccion.Size = new Size(100, 23);
            txtbDireccion.TabIndex = 19;
            // 
            // txtbTelefono
            // 
            txtbTelefono.Location = new Point(148, 290);
            txtbTelefono.Name = "txtbTelefono";
            txtbTelefono.Size = new Size(100, 23);
            txtbTelefono.TabIndex = 20;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(150, 328);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(100, 23);
            txtbEmail.TabIndex = 21;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(150, 200);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 22;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(709, 418);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 23;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(626, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtbEmail);
            Controls.Add(txtbTelefono);
            Controls.Add(txtbDireccion);
            Controls.Add(txtbContrasenia);
            Controls.Add(txtbUsuario);
            Controls.Add(txtbApellido);
            Controls.Add(txtbNombre);
            Controls.Add(cbAdministrativo);
            Controls.Add(cbProfesor);
            Controls.Add(cbAlumno);
            Controls.Add(lblTipoUsuarios);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosCuenta);
            Controls.Add(lblDatosPersonales);
            Controls.Add(lblCrearNuevoUsuario);
            Font = new Font("Segoe UI", 9F);
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrearNuevoUsuario;
        private Label lblDatosPersonales;
        private Label lblDatosCuenta;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblFechaNacimiento;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblUsuario;
        private Label lblContrasenia;
        private Label lblTipoUsuarios;
        private CheckBox cbAlumno;
        private CheckBox cbProfesor;
        private CheckBox cbAdministrativo;
        private TextBox txtbNombre;
        private TextBox txtbApellido;
        private TextBox txtbUsuario;
        private TextBox txtbContrasenia;
        private TextBox txtbDireccion;
        private TextBox txtbTelefono;
        private TextBox txtbEmail;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}