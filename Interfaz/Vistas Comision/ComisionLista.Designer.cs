namespace Interfaz.Vistas_Comision
{
    partial class ComisionLista
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
            modificarButton = new Button();
            agregarButton = new Button();
            eliminarButton = new Button();
            comisionesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(496, 359);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(112, 34);
            modificarButton.TabIndex = 7;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(645, 359);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(112, 34);
            agregarButton.TabIndex = 6;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(344, 359);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(112, 34);
            eliminarButton.TabIndex = 5;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // comisionesDataGridView
            // 
            comisionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comisionesDataGridView.Location = new Point(43, 58);
            comisionesDataGridView.Name = "comisionesDataGridView";
            comisionesDataGridView.RowHeadersWidth = 62;
            comisionesDataGridView.Size = new Size(703, 269);
            comisionesDataGridView.TabIndex = 4;
            // 
            // ComisionLista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(eliminarButton);
            Controls.Add(comisionesDataGridView);
            Name = "ComisionLista";
            Text = "ComisionLista";
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button modificarButton;
        private Button agregarButton;
        private Button eliminarButton;
        private DataGridView comisionesDataGridView;
    }
}