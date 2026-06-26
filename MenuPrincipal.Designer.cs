namespace Fase4JhonnyMauricioRivera
{
    partial class MenuPrincipal
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
            menuStrip1 = new MenuStrip();
            escenario1ToolStripMenuItem = new ToolStripMenuItem();
            escenario2ToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { escenario1ToolStripMenuItem, escenario2ToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(380, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // escenario1ToolStripMenuItem
            // 
            escenario1ToolStripMenuItem.BackColor = Color.Red;
            escenario1ToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            escenario1ToolStripMenuItem.ForeColor = Color.White;
            escenario1ToolStripMenuItem.Name = "escenario1ToolStripMenuItem";
            escenario1ToolStripMenuItem.Size = new Size(125, 29);
            escenario1ToolStripMenuItem.Text = "Escenario 1 ";
            escenario1ToolStripMenuItem.Click += escenario1ToolStripMenuItem_Click;
            // 
            // escenario2ToolStripMenuItem
            // 
            escenario2ToolStripMenuItem.BackColor = Color.Blue;
            escenario2ToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            escenario2ToolStripMenuItem.ForeColor = Color.White;
            escenario2ToolStripMenuItem.Name = "escenario2ToolStripMenuItem";
            escenario2ToolStripMenuItem.Size = new Size(125, 29);
            escenario2ToolStripMenuItem.Text = "Escenario 2 ";
            escenario2ToolStripMenuItem.Click += escenario2ToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 46);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem escenario1ToolStripMenuItem;
        private ToolStripMenuItem escenario2ToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}