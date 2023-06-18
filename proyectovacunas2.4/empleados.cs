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

namespace Empleados
{

    public partial class frmEmpleados : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();
        public frmEmpleados()
        {
            InitializeComponent();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.IsNullOrEmpty() || txtEdad.Text.IsNullOrEmpty() || txtDepartamento.Text.IsNullOrEmpty() || txtDireccion.Text.IsNullOrEmpty() || txtCargo.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Rellene todos los campos");

            }
            else
            {

                tabla.Rows.Add(txtNombre.Text, txtEdad.Text, txtDepartamento.Text, txtDireccion.Text, txtCargo.Text);
                MessageBox.Show(_con.Insertar_Empleado(txtNombre.Text, int.Parse(txtEdad.Text), txtDepartamento.Text, txtDireccion.Text, txtCargo.Text));

                txtNombre.Text = "";
                txtEdad.Text = "";
                txtDepartamento.Text = "";
                txtDireccion.Text = "";
                txtCargo.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            frmEliminarEmpleado emp = new frmEliminarEmpleado();
            emp.ShowDialog(this);

        }



        private void button2_Click(object sender, EventArgs e)
        {


            string cadenasql = "SELECT * FROM Empleado";
            string[] reg = new string[5];

            tabla.Rows.Clear();
            try
            {
                _con.cn.Open();
                _con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, _con.cn);
                _con.rd = _con.cmd.ExecuteReader();

                while (_con.rd.Read())
                {
                    reg[0] = _con.rd[0].ToString();
                    reg[1] = _con.rd[1].ToString();
                    reg[2] = _con.rd[2].ToString();
                    reg[3] = _con.rd[3].ToString();
                    reg[4] = _con.rd[4].ToString();

                    tabla.Rows.Add(reg[0], reg[1], reg[2], reg[3], reg[4]);
                }

                _con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _con.cn.Close();
            }
        }


        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
