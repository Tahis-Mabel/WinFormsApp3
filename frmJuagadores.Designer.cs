namespace WinFormsApp3
{
    partial class frmJuagadores
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
            panel1 = new Panel();
            txtFiltro = new TextBox();
            panel2 = new Panel();
            grdJugadores = new DataGridView();
            panel3 = new Panel();
            btnNuevo = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdJugadores).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 26);
            panel1.TabIndex = 0;
            // 
            // txtFiltro
            // 
            txtFiltro.Dock = DockStyle.Top;
            txtFiltro.Location = new Point(0, 0);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(434, 23);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(grdJugadores);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 158);
            panel2.TabIndex = 1;
            // 
            // grdJugadores
            // 
            grdJugadores.AllowUserToAddRows = false;
            grdJugadores.AllowUserToDeleteRows = false;
            grdJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdJugadores.Dock = DockStyle.Fill;
            grdJugadores.Location = new Point(0, 0);
            grdJugadores.Name = "grdJugadores";
            grdJugadores.ReadOnly = true;
            grdJugadores.Size = new Size(434, 158);
            grdJugadores.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNuevo);
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnSalir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 35);
            panel3.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.Dock = DockStyle.Right;
            btnNuevo.Location = new Point(134, 0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 35);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Dock = DockStyle.Right;
            btnActualizar.Location = new Point(209, 0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 35);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Right;
            btnEliminar.Location = new Point(284, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 35);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(359, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 35);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmJuagadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 219);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmJuagadores";
            Text = "Jugadores";
            Load += frmJuagadores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdJugadores).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtFiltro;
        private Panel panel2;
        private Panel panel3;
        private DataGridView grdJugadores;
        private Button btnNuevo;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}