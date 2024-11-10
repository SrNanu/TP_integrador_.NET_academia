namespace Interfaz.Vistas_Profesor
{
    partial class MenuProfesor
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
            btnCargarNotas = new Button();
            btnMaterias = new Button();
            btnEspecialidades = new Button();
            btnCursos = new Button();
            btnPlanes = new Button();
            btnComisiones = new Button();
            lknLogOut = new LinkLabel();
            btnReporteCursos = new Button();
            btnReportePlanes = new Button();
            SuspendLayout();
            // 
            // btnCargarNotas
            // 
            btnCargarNotas.Location = new Point(112, 60);
            btnCargarNotas.Name = "btnCargarNotas";
            btnCargarNotas.Size = new Size(143, 52);
            btnCargarNotas.TabIndex = 0;
            btnCargarNotas.Text = "Cargar Notas";
            btnCargarNotas.UseVisualStyleBackColor = true;
            btnCargarNotas.Click += btnCargarNotas_Click;
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(112, 137);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(140, 48);
            btnMaterias.TabIndex = 1;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += OpenMaterias;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.Location = new Point(112, 214);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new Size(138, 49);
            btnEspecialidades.TabIndex = 2;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.UseVisualStyleBackColor = true;
            btnEspecialidades.Click += OpenEspecialidades;
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(393, 63);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(138, 49);
            btnCursos.TabIndex = 3;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += OpenCursos;
            // 
            // btnPlanes
            // 
            btnPlanes.Location = new Point(393, 137);
            btnPlanes.Name = "btnPlanes";
            btnPlanes.Size = new Size(138, 49);
            btnPlanes.TabIndex = 4;
            btnPlanes.Text = "Planes";
            btnPlanes.UseVisualStyleBackColor = true;
            btnPlanes.Click += OpenPlanes;
            // 
            // btnComisiones
            // 
            btnComisiones.Location = new Point(393, 214);
            btnComisiones.Name = "btnComisiones";
            btnComisiones.Size = new Size(138, 49);
            btnComisiones.TabIndex = 5;
            btnComisiones.Text = "Comisiones";
            btnComisiones.UseVisualStyleBackColor = true;
            btnComisiones.Click += OpenComisiones;
            // 
            // lknLogOut
            // 
            lknLogOut.AutoSize = true;
            lknLogOut.Location = new Point(23, 417);
            lknLogOut.Name = "lknLogOut";
            lknLogOut.Size = new Size(47, 15);
            lknLogOut.TabIndex = 6;
            lknLogOut.TabStop = true;
            lknLogOut.Text = "LogOut";
            lknLogOut.Click += lknLogOut_Click;
            // 
            // btnReporteCursos
            // 
            btnReporteCursos.Location = new Point(112, 295);
            btnReporteCursos.Name = "btnReporteCursos";
            btnReporteCursos.Size = new Size(138, 48);
            btnReporteCursos.TabIndex = 7;
            btnReporteCursos.Text = "Reporte Cursos";
            btnReporteCursos.UseVisualStyleBackColor = true;
            btnReporteCursos.Click += GenerarReporteCursos;
            // 
            // btnReportePlanes
            // 
            btnReportePlanes.Location = new Point(393, 295);
            btnReportePlanes.Name = "btnReportePlanes";
            btnReportePlanes.Size = new Size(138, 48);
            btnReportePlanes.TabIndex = 8;
            btnReportePlanes.Text = "Reporte Planes";
            btnReportePlanes.UseVisualStyleBackColor = true;
            btnReportePlanes.Click += GenerarReportePlanes;
            // 
            // MenuProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportePlanes);
            Controls.Add(btnReporteCursos);
            Controls.Add(lknLogOut);
            Controls.Add(btnComisiones);
            Controls.Add(btnPlanes);
            Controls.Add(btnCursos);
            Controls.Add(btnEspecialidades);
            Controls.Add(btnMaterias);
            Controls.Add(btnCargarNotas);
            Name = "MenuProfesor";
            Text = "Menu Profesores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarNotas;
        private Button btnMaterias;
        private Button btnEspecialidades;
        private Button btnCursos;
        private Button btnPlanes;
        private Button btnComisiones;
        private LinkLabel lknLogOut;
        private Button btnReporteCursos;
        private Button btnReportePlanes;
    }
}