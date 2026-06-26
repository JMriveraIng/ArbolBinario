namespace Fase4JhonnyMauricioRivera
{
    partial class Escenario2
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            gRAFICOToolStripMenuItem = new ToolStripMenuItem();
            rECORRIDOSToolStripMenuItem = new ToolStripMenuItem();
            inOrderToolStripMenuItem = new ToolStripMenuItem();
            preOrderToolStripMenuItem = new ToolStripMenuItem();
            postOrderToolStripMenuItem = new ToolStripMenuItem();
            vOLVERALMENUToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gRAFICOToolStripMenuItem, rECORRIDOSToolStripMenuItem, vOLVERALMENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(892, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gRAFICOToolStripMenuItem
            // 
            gRAFICOToolStripMenuItem.Name = "gRAFICOToolStripMenuItem";
            gRAFICOToolStripMenuItem.Size = new Size(68, 20);
            gRAFICOToolStripMenuItem.Text = "GRAFICO";
            gRAFICOToolStripMenuItem.Click += gRAFICOToolStripMenuItem_Click;
            // 
            // rECORRIDOSToolStripMenuItem
            // 
            rECORRIDOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inOrderToolStripMenuItem, preOrderToolStripMenuItem, postOrderToolStripMenuItem });
            rECORRIDOSToolStripMenuItem.Enabled = false;
            rECORRIDOSToolStripMenuItem.Name = "rECORRIDOSToolStripMenuItem";
            rECORRIDOSToolStripMenuItem.Size = new Size(89, 20);
            rECORRIDOSToolStripMenuItem.Text = "RECORRIDOS";
            // 
            // inOrderToolStripMenuItem
            // 
            inOrderToolStripMenuItem.Name = "inOrderToolStripMenuItem";
            inOrderToolStripMenuItem.Size = new Size(127, 22);
            inOrderToolStripMenuItem.Text = "InOrder";
            inOrderToolStripMenuItem.Click += inOrderToolStripMenuItem_Click;
            // 
            // preOrderToolStripMenuItem
            // 
            preOrderToolStripMenuItem.Name = "preOrderToolStripMenuItem";
            preOrderToolStripMenuItem.Size = new Size(127, 22);
            preOrderToolStripMenuItem.Text = "PreOrder";
            preOrderToolStripMenuItem.Click += preOrderToolStripMenuItem_Click;
            // 
            // postOrderToolStripMenuItem
            // 
            postOrderToolStripMenuItem.Name = "postOrderToolStripMenuItem";
            postOrderToolStripMenuItem.Size = new Size(127, 22);
            postOrderToolStripMenuItem.Text = "PostOrder";
            postOrderToolStripMenuItem.Click += postOrderToolStripMenuItem_Click;
            // 
            // vOLVERALMENUToolStripMenuItem
            // 
            vOLVERALMENUToolStripMenuItem.Name = "vOLVERALMENUToolStripMenuItem";
            vOLVERALMENUToolStripMenuItem.Size = new Size(114, 20);
            vOLVERALMENUToolStripMenuItem.Text = "VOLVER AL MENU";
            vOLVERALMENUToolStripMenuItem.Click += vOLVERALMENUToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(870, 457);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // Escenario2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 512);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Escenario2";
            Text = "Escenario2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gRAFICOToolStripMenuItem;
        private ToolStripMenuItem rECORRIDOSToolStripMenuItem;
        private ToolStripMenuItem inOrderToolStripMenuItem;
        private ToolStripMenuItem preOrderToolStripMenuItem;
        private ToolStripMenuItem postOrderToolStripMenuItem;
        private ToolStripMenuItem vOLVERALMENUToolStripMenuItem;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}