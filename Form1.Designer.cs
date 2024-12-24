namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnJugadores = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnJugadores
            // 
            btnJugadores.Location = new Point(28, 29);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(82, 33);
            btnJugadores.TabIndex = 0;
            btnJugadores.Text = "Jugadores";
            btnJugadores.UseVisualStyleBackColor = true;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 29);
            button2.Name = "button2";
            button2.Size = new Size(82, 33);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(213, 29);
            button3.Name = "button3";
            button3.Size = new Size(82, 33);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 83);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnJugadores);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnJugadores;
        private Button button2;
        private Button button3;
    }
}
