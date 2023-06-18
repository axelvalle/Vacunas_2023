using Administracion_de_vacunas;
using CampañadeVac;
using centrodesalus;
using Empleados;

using Reg_vacuna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectovacunas2._4
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnEmp_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
            Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte rep = new Reporte();
            rep.Show();


        }

        private void btnJornadas_Click(object sender, EventArgs e)
        {
            frmCampañaVA campañas = new frmCampañaVA();
            campañas.Show();
            Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegVac regvac = new frmRegVac();
            regvac.Show();
            Hide();
        }

        private void btnAdminVac_Click(object sender, EventArgs e)
        {
            frmvacunacion admin_Vacuna = new frmvacunacion();
            admin_Vacuna.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCentroInfo infocentro = new frmCentroInfo();
            infocentro.Show();
            Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
