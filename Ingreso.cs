namespace Fase4JhonnyMauricioRivera
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal mnuPrincipal = new MenuPrincipal();
            Ingreso ing = new Ingreso();
            string clave = Clave.Text;
            if (clave == "UNAD") { 
                mnuPrincipal.Show();
                ing.Hide();
            } else
            {
                MessageBox.Show("CLAVE INCORRECTA");
            }
        }
    }
}
