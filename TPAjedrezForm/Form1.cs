using TPAjedrez.Piezas;

namespace TPAjedrezForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            Torre torre = new Torre();
            Peon peon= new Peon();

            MessageBox.Show(caballo.Mover());
            MessageBox.Show(torre.Mover());
            MessageBox.Show(peon.Mover());
        }

    }
}