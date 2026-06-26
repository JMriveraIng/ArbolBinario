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
    public partial class Escenario2 : Form
    {
        public Escenario2()
        {
            InitializeComponent();
        }

        private void gRAFICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics hoja;
            hoja = pictureBox1.CreateGraphics();

            Pen lapiz = new Pen(Color.Red);
            Font fuente = new Font("Arial", 19);
            SolidBrush relleno = new SolidBrush(Color.Red);
            SolidBrush relleno2 = new SolidBrush(Color.Blue);

            //RAMAS IZQUIERDA
            //NODO RAIZ PISO 1
            hoja.FillEllipse(relleno2, 440, 1, 50, 50);
            hoja.DrawString("26", fuente, Brushes.Yellow, 447, 10);
            //NODO INTERNO PISO 2
            hoja.FillEllipse(relleno, 250, 90, 50, 50);
            hoja.DrawString("20", fuente, Brushes.Yellow, 257, 100);
            hoja.DrawLine(lapiz, 447, 30, 290, 108);
            //NODOS INTERNOS PISO 3
            hoja.FillEllipse(relleno, 150, 200, 50, 50);
            hoja.DrawString("17", fuente, Brushes.Yellow, 157, 210);
            hoja.DrawLine(lapiz, 280, 110, 180, 220);
            hoja.FillEllipse(relleno, 400, 200, 50, 50);
            hoja.DrawString("25", fuente, Brushes.Yellow, 407, 210);
            hoja.DrawLine(lapiz, 280, 110, 440, 245);
            //NODOS HOJA PISO 4
            hoja.FillEllipse(relleno, 350, 320, 50, 50);
            hoja.DrawString("24", fuente, Brushes.Yellow, 357, 330);
            hoja.DrawLine(lapiz, 420, 245, 370, 350);

            //RAMAS DERECHA
            //NODO INTERNO PISO 2
            hoja.FillEllipse(relleno, 590, 95, 50, 50);
            hoja.DrawString("31", fuente, Brushes.Yellow, 597, 105);
            hoja.DrawLine(lapiz, 490, 37, 607, 105);
            //NODOS INTERNOS PISO 3
            hoja.FillEllipse(relleno, 520, 200, 50, 50);
            hoja.DrawString("28", fuente, Brushes.Yellow, 527, 210);
            hoja.DrawLine(lapiz, 617, 115, 527, 230);
            hoja.FillEllipse(relleno, 720, 200, 50, 50);
            hoja.DrawString("55", fuente, Brushes.Yellow, 727, 210);
            hoja.DrawLine(lapiz, 640, 130, 735, 210);
            //NODOS HOJA PISO 4
            hoja.FillEllipse(relleno, 620, 320, 50, 50);
            hoja.DrawString("37", fuente, Brushes.Yellow, 627, 330);
            hoja.DrawLine(lapiz, 725, 230, 627, 350);

            rECORRIDOSToolStripMenuItem.Enabled = true;
        }

        private void inOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        int contador = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics hoja;
            hoja = pictureBox1.CreateGraphics();

            Pen lapiz = new Pen(Color.Black);
            Font fuente = new Font("Arial", 19);
            SolidBrush relleno = new SolidBrush(Color.Purple);
            SolidBrush relleno2 = new SolidBrush(Color.Orange);

            // INORDER (Left-Root-Right)
            switch (contador)
            {
                case 1:
                    //RAMA IZQUIERDA (LEFT)
                    //LEFT
                    hoja.FillEllipse(relleno, 150, 200, 50, 50);
                    hoja.DrawString("17", fuente, Brushes.Yellow, 157, 210);
                    break;
                case 2:
                    //ROOT
                    hoja.FillEllipse(relleno, 250, 90, 50, 50);
                    hoja.DrawString("20", fuente, Brushes.Yellow, 257, 100);
                    break;
                case 3:
                    //ROOT
                    hoja.FillEllipse(relleno, 350, 320, 50, 50);
                    hoja.DrawString("24", fuente, Brushes.Yellow, 357, 330);
                    break;
                case 4:
                    //LEFT
                    hoja.FillEllipse(relleno, 400, 200, 50, 50);
                    hoja.DrawString("25", fuente, Brushes.Yellow, 407, 210);
                    break;
                //RAIZ DEL ARBOL (ROOT)
                case 5:
                    //ROOT
                    hoja.FillEllipse(relleno2, 440, 1, 50, 50);
                    hoja.DrawString("26", fuente, Brushes.Yellow, 447, 10);
                    break;
                // RAMA DERECHA (RIGHT)
                case 6:
                    //IZQUIERDA
                    hoja.FillEllipse(relleno, 520, 200, 50, 50);
                    hoja.DrawString("28", fuente, Brushes.Yellow, 527, 210);
                    break;
                case 7:
                    //ROOT
                    hoja.FillEllipse(relleno, 590, 95, 50, 50);
                    hoja.DrawString("31", fuente, Brushes.Yellow, 597, 105);
                    break;
                case 8:
                    //LEFT
                    hoja.FillEllipse(relleno, 620, 320, 50, 50);
                    hoja.DrawString("37", fuente, Brushes.Yellow, 627, 330);
                    break;
                case 9:
                    //RIGHT
                    hoja.FillEllipse(relleno, 720, 200, 50, 50);
                    hoja.DrawString("55", fuente, Brushes.Yellow, 727, 210);
                    break;
            }
            contador++;
            if (contador > 9)
            {
                timer1.Stop();
                MessageBox.Show("InOrder ( Izquierda,Raiz,Derecha ) " + "17,20,24,25,26,28,31,37,55");
                hoja.Clear(Color.White);
                rECORRIDOSToolStripMenuItem.Enabled = false;
            }
        }



        private void vOLVERALMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal mnu = new MenuPrincipal();
            this.Hide();
            mnu.Show();
        }

        private void preOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        ////PREORDER (Root-Left-Right)
        int contador2 = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Graphics hoja;
            hoja = pictureBox1.CreateGraphics();

            Pen lapiz = new Pen(Color.Black);
            Font fuente = new Font("Arial", 19);
            SolidBrush relleno = new SolidBrush(Color.Purple);
            SolidBrush relleno2 = new SolidBrush(Color.Orange);

            // PREORDER (Root-Left-Right)
            switch (contador2)
            {
                case 1:
                    //RAIZ DEL ARBOL (root)
                    //ROOT
                    hoja.FillEllipse(relleno2, 440, 1, 50, 50);
                    hoja.DrawString("26", fuente, Brushes.Yellow, 447, 10);
                    break;
                // RAMA IZQUIERDA (Left)
                case 2:
                    //LEFT
                    hoja.FillEllipse(relleno, 250, 90, 50, 50);
                    hoja.DrawString("20", fuente, Brushes.Yellow, 257, 100);
                    break;
                case 3:
                    //LEFT
                    hoja.FillEllipse(relleno, 150, 200, 50, 50);
                    hoja.DrawString("17", fuente, Brushes.Yellow, 157, 210);
                    break;
                case 4:
                    //RIGTH
                    hoja.FillEllipse(relleno, 400, 200, 50, 50);
                    hoja.DrawString("25", fuente, Brushes.Yellow, 407, 210);
                    break;
                case 5:
                    //ROOT
                    hoja.FillEllipse(relleno, 350, 320, 50, 50);
                    hoja.DrawString("24", fuente, Brushes.Yellow, 357, 330);
                    break;
                // RAMA DERECHA (RIGHT)
                case 6:
                    //ROOT
                    hoja.FillEllipse(relleno, 590, 95, 50, 50);
                    hoja.DrawString("31", fuente, Brushes.Yellow, 597, 105);
                    break;
                case 7:
                    //LEFT
                    hoja.FillEllipse(relleno, 520, 200, 50, 50);
                    hoja.DrawString("28", fuente, Brushes.Yellow, 527, 210);
                    break;
                case 8:
                    //RIGHT
                    hoja.FillEllipse(relleno, 720, 200, 50, 50);
                    hoja.DrawString("55", fuente, Brushes.Yellow, 727, 210);
                    break;
                case 9:
                    //ROOT
                    hoja.FillEllipse(relleno, 620, 320, 50, 50);
                    hoja.DrawString("37", fuente, Brushes.Yellow, 627, 330);
                    break;

            }
            contador2++;
            if (contador2 > 9)
            {
                timer2.Stop();
                MessageBox.Show("PreOrder( Raiz,Izquierda,Derecha ) " + "26,20,17,25,24,31,28,55,37");
                hoja.Clear(Color.White);
                rECORRIDOSToolStripMenuItem.Enabled = false;
            }
        }

        private void postOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        //POSTORDEN (Left-Rigth-Root)
        int contador3 = 1;
        private void timer3_Tick(object sender, EventArgs e)
        {
            Graphics hoja;
            hoja = pictureBox1.CreateGraphics();

            Pen lapiz = new Pen(Color.Black);
            Font fuente = new Font("Arial", 19);
            SolidBrush relleno = new SolidBrush(Color.Purple);
            SolidBrush relleno2 = new SolidBrush(Color.Orange);

            // POSTORDER (Left-Right-Root)
            switch (contador3)
            {
                case 1:
                    //RAMA IZQUIERDA (LEFT)
                    //LEFT
                    hoja.FillEllipse(relleno, 150, 200, 50, 50);
                    hoja.DrawString("17", fuente, Brushes.Yellow, 157, 210);
                    break;
                case 2:
                    //LEFT
                    hoja.FillEllipse(relleno, 350, 320, 50, 50);
                    hoja.DrawString("24", fuente, Brushes.Yellow, 357, 330);
                    break;
                case 3:
                    //RIGTH
                    hoja.FillEllipse(relleno, 400, 200, 50, 50);
                    hoja.DrawString("25", fuente, Brushes.Yellow, 407, 210);
                    break;
                case 4:
                    //ROOT
                    hoja.FillEllipse(relleno, 250, 90, 50, 50);
                    hoja.DrawString("20", fuente, Brushes.Yellow, 257, 100);
                    break;
                // RAMA DERECHA (RIGHT)
                case 5:
                    //LEFT
                    hoja.FillEllipse(relleno, 520, 200, 50, 50);
                    hoja.DrawString("28", fuente, Brushes.Yellow, 527, 210);
                    break;
                case 6:
                    //LEFT
                    hoja.FillEllipse(relleno, 620, 320, 50, 50);
                    hoja.DrawString("37", fuente, Brushes.Yellow, 627, 330);
                    break;
                case 7:
                    //RIGHT
                    hoja.FillEllipse(relleno, 720, 200, 50, 50);
                    hoja.DrawString("55", fuente, Brushes.Yellow, 727, 210);
                    break;
                case 8:
                    //ROOT
                    hoja.FillEllipse(relleno, 590, 95, 50, 50);
                    hoja.DrawString("31", fuente, Brushes.Yellow, 597, 105);
                    break;
                //RAIZ DEL ARBOL (root)
                case 9:
                    //ROOT
                    hoja.FillEllipse(relleno2, 440, 1, 50, 50);
                    hoja.DrawString("26", fuente, Brushes.Yellow, 447, 10);
                    break;
            }
            contador3++;
            if (contador3 > 12)
            {
                timer3.Stop();
                MessageBox.Show("PostOrder( Izquierda,Derecha,Raiz ) " + "17,24,25,20,28,37,55,31,26");
                hoja.Clear(Color.White);
                rECORRIDOSToolStripMenuItem.Enabled = false;
            }
        }
    }
}
