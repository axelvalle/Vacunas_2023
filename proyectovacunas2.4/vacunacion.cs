using proyectovacunas2._4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Administracion_de_vacunas
{
    public partial class frmvacunacion : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        string[] reg = new string[6];
        public frmvacunacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Hide();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmInformacion u = new frmInformacion();
            u.ShowDialog();



        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmPrincipal prin = new frmPrincipal();
            prin.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaciente.Text) || string.IsNullOrEmpty(txtEdadPaciente.Text) || string.IsNullOrEmpty(cbVacuna.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtEnfermedad.Text) || string.IsNullOrEmpty(dtPrimeraDosis.Text) || string.IsNullOrEmpty(dtSegundaDosis.Text) || string.IsNullOrEmpty(txtObservaciones.Text))
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                MessageBox.Show(con.Insertar_Paciente(txtPaciente.Text, txtEdadPaciente.Text, cbVacuna.Text, txtDireccion.Text, txtEnfermedad.Text, dtPrimeraDosis.Text, dtSegundaDosis.Text, txtObservaciones.Text));
                txtPaciente.Text = "";
                txtObservaciones.Text = "";
                txtEnfermedad.Text = "";
                txtEdadPaciente.Text = "";
                txtDireccion.Text = "";
                cbVacuna.Text = "";
            }



        }

        private void frmvacunacion_Load(object sender, EventArgs e)
        {

            string cadenasql = "SELECT * FROM Registro_Vacuna";


            cbVacuna.Items.Clear();
            try
            {
                con.cn.Open();
                con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, con.cn);
                con.rd = con.cmd.ExecuteReader();

                while (con.rd.Read())
                {
                    reg[0] = con.rd[0].ToString();
                    reg[1] = con.rd[1].ToString();
                    reg[2] = con.rd[2].ToString();
                    reg[3] = con.rd[3].ToString();
                    reg[4] = con.rd[4].ToString();
                    reg[5] = con.rd[5].ToString();



                    cbVacuna.Items.Add(reg[0]);
                }

                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.cn.Close();
            }
        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
