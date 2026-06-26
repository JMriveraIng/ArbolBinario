namespace Fase4JhonnyMauricioRivera
{
    partial class Ingreso
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
            label1 = new Label();
            label2 = new Label();
            Clave = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(62, 41);
            label1.Name = "label1";
            label1.Size = new Size(436, 41);
            label1.TabIndex = 0;
            label1.Text = "ARBOL BINARIO DE BUSQUEDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(142, 126);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // Clave
            // 
            Clave.Location = new Point(297, 131);
            Clave.Name = "Clave";
            Clave.Size = new Size(147, 23);
            Clave.TabIndex = 2;
            Clave.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(208, 171);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 3;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(157, 279);
            label3.Name = "label3";
            label3.Size = new Size(256, 25);
            label3.TabIndex = 4;
            label3.Text = "Jhonny Mauricio Rivera Ruseria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(180, 221);
            label4.Name = "label4";
            label4.Size = new Size(187, 21);
            label4.TabIndex = 5;
            label4.Text = "Martes, 14 de Mayo 2024";
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 331);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(Clave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ingreso";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Clave;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}
