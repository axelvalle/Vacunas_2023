using System;
using System.Windows.Forms;

namespace proyectovacunas2._4
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {


        }

        private void barraprogresivz_Click(object sender, EventArgs e)
        {

        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {


        }
        private void timer2_Tick(object sender, EventArgs e)
        {



        }

        private void timer1_Tick(object sender, EventArgs e)
        {





        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios n = new Usuarios();
            n.Show();
            this.Hide();

        }

        private void botonsalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
