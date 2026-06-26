namespace Fase4JhonnyMauricioRivera
{
    partial class Escenario1
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
            gRAFICAToolStripMenuItem = new ToolStripMenuItem();
            rECORRIDOSToolStripMenuItem = new ToolStripMenuItem();
            inordenToolStripMenuItem = new ToolStripMenuItem();
            preOrdenToolStripMenuItem = new ToolStripMenuItem();
            postOrdenToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { gRAFICAToolStripMenuItem, rECORRIDOSToolStripMenuItem, sALIRToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(983, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gRAFICAToolStripMenuItem
            // 
            gRAFICAToolStripMenuItem.Name = "gRAFICAToolStripMenuItem";
            gRAFICAToolStripMenuItem.Size = new Size(67, 20);
            gRAFICAToolStripMenuItem.Text = "GRAFICA";
            gRAFICAToolStripMenuItem.Click += gRAFICAToolStripMenuItem_Click;
            // 
            // rECORRIDOSToolStripMenuItem
            // 
            rECORRIDOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inordenToolStripMenuItem, preOrdenToolStripMenuItem, postOrdenToolStripMenuItem });
            rECORRIDOSToolStripMenuItem.Enabled = false;
            rECORRIDOSToolStripMenuItem.Name = "rECORRIDOSToolStripMenuItem";
            rECORRIDOSToolStripMenuItem.Size = new Size(89, 20);
            rECORRIDOSToolStripMenuItem.Text = "RECORRIDOS";
            // 
            // inordenToolStripMenuItem
            // 
            inordenToolStripMenuItem.Name = "inordenToolStripMenuItem";
            inordenToolStripMenuItem.Size = new Size(130, 22);
            inordenToolStripMenuItem.Text = "Inorden";
            inordenToolStripMenuItem.Click += inordenToolStripMenuItem_Click;
            // 
            // preOrdenToolStripMenuItem
            // 
            preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            preOrdenToolStripMenuItem.Size = new Size(130, 22);
            preOrdenToolStripMenuItem.Text = "PreOrden";
            preOrdenToolStripMenuItem.Click += preOrdenToolStripMenuItem_Click;
            // 
            // postOrdenToolStripMenuItem
            // 
            postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            postOrdenToolStripMenuItem.Size = new Size(130, 22);
            postOrdenToolStripMenuItem.Text = "PostOrden";
            postOrdenToolStripMenuItem.Click += postOrdenToolStripMenuItem_Click;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(114, 20);
            sALIRToolStripMenuItem.Text = "VOLVER AL MENU";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(965, 475);
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
            // Escenario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 509);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Escenario1";
            Text = "Escenario1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gRAFICAToolStripMenuItem;
        private ToolStripMenuItem rECORRIDOSToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private ToolStripMenuItem preOrdenToolStripMenuItem;
        private ToolStripMenuItem inordenToolStripMenuItem;
        private ToolStripMenuItem postOrdenToolStripMenuItem;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}