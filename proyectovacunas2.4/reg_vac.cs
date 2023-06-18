using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reg_vacuna
{
    public partial class frmRegVac : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        public frmRegVac()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txifo_Click(object sender, EventArgs e)
        {

        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.IsNullOrEmpty() || txtTipo.Text.IsNullOrEmpty() || txtDosis.Text.IsNullOrEmpty() || txtFechaVencimiento.Text.IsNullOrEmpty() || txtEfectos.Text.IsNullOrEmpty() || txtInfo.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                Tabla.Rows.Add(txtNombre.Text, txtTipo.Text, txtDosis.Text, txtFechaVencimiento.Text, txtEfectos.Text, txtInfo.Text);
                MessageBox.Show(con.Insertar_Vacuna(txtNombre.Text, txtTipo.Text, txtDosis.Text, txtFechaVencimiento.Text, txtEfectos.Text, txtInfo.Text));

                txtNombre.Text = "";
                txtTipo.Text = "";
                txtDosis.Text = "";
                txtFechaVencimiento.Text = "";
                txtEfectos.Text = "";
                txtInfo.Text = "";
            }


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            string cadenasql = "SELECT * FROM Registro_Vacuna";
            string[] reg = new string[6];

            Tabla.Rows.Clear();
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

                    Tabla.Rows.Add(reg[0], reg[1], reg[2], reg[3], reg[4], reg[5]);
                }

                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.cn.Close();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Tabla.Rows.Clear();
        }

        private void frmRegVac_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            frmEliminarVacuna eliminarVacuna = new frmEliminarVacuna();
            eliminarVacuna.ShowDialog();
        }
    }
}
