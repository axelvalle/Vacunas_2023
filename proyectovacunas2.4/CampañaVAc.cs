using proyectovacunas2._4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampañadeVac
{
    public partial class frmCampañaVA : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        public frmCampañaVA()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Hide();
        }

        private void frmCampañaVA_Load(object sender, EventArgs e)
        {
            leercomboRegVac();
            leercomboEmpleados();
        }

        public void leercomboRegVac()
        {
            string cadenasql = "SELECT * FROM Registro_Vacuna";
            string[] reg = new string[1];

            comboBoxVacunas.Items.Clear();
            try
            {
                con.cn.Open();
                con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, con.cn);
                con.rd = con.cmd.ExecuteReader();

                while (con.rd.Read())
                {
                    reg[0] = con.rd[0].ToString();




                    comboBoxVacunas.Items.Add(reg[0]);
                }

                con.cn.Close();


            }
            catch (Exception ex) { }
        }
        public void leercomboEmpleados()
        {
            string cadenasql = "SELECT * FROM Empleado";
            string[] reg = new string[1];

            comboBoxEmpleados.Items.Clear();
            try
            {
                con.cn.Open();
                con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, con.cn);
                con.rd = con.cmd.ExecuteReader();

                while (con.rd.Read())
                {
                    reg[0] = con.rd[0].ToString();




                    comboBoxEmpleados.Items.Add(reg[0]);
                }

                con.cn.Close();


            }
            catch (Exception ex) { }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.Insertar_Campaña(DTFecha.Text, txtEjecutada.Text, comboBoxVacunas.Text, comboBoxRangodeEdades.Text, txtLugar.Text, comboBoxEmpleados.Text));
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            tablaCampañas campañas = new tablaCampañas();   
            campañas.ShowDialog();
        }
    }
}
