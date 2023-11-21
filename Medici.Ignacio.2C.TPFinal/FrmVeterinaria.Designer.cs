namespace Medici.Ignacio._2C.TPFinal
{
    partial class FrmVeterinaria
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(298, 118);
            button1.Name = "button1";
            button1.Size = new Size(193, 33);
            button1.TabIndex = 0;
            button1.Text = "Cargar consulta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(298, 157);
            button2.Name = "button2";
            button2.Size = new Size(193, 30);
            button2.TabIndex = 1;
            button2.Text = "Modificar consulta";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(298, 193);
            button3.Name = "button3";
            button3.Size = new Size(193, 29);
            button3.TabIndex = 2;
            button3.Text = "Mostrar consultas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(298, 228);
            button4.Name = "button4";
            button4.Size = new Size(193, 30);
            button4.TabIndex = 3;
            button4.Text = "Eliminar consultas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(298, 264);
            button5.Name = "button5";
            button5.Size = new Size(193, 29);
            button5.TabIndex = 4;
            button5.Text = "Guardar consultas";
            button5.UseVisualStyleBackColor = true;
            // 
            // FrmVeterinaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVeterinaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veterinaria Alumno: Ignacio Medici";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}