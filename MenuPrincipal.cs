using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4JhonnyMauricioRivera
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void escenario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escenario1 esc1 = new Escenario1();
            esc1.Show();
            this.Hide();
        }

        private void escenario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escenario2 esc2=new Escenario2();
            esc2.Show();
            this.Hide();
        }
    }
}
