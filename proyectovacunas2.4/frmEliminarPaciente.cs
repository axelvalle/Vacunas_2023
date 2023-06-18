using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectovacunas2._4
{
    public partial class frmEliminarPaciente : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        public frmEliminarPaciente()
        {
            InitializeComponent();
        }

        private void frmEliminarPaciente_Load(object sender, EventArgs e)
        {
            string cadenasql = "SELECT * FROM Vacunacion";
            string[] reg = new string[1];

            cbPacientes.Items.Clear();
            try
            {
                con.cn.Open();
                con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, con.cn);
                con.rd = con.cmd.ExecuteReader();

                while (con.rd.Read())
                {
                    reg[0] = con.rd[0].ToString();

                    cbPacientes.Items.Add(reg[0]);
                }

                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.Eliminar_Paciente(cbPacientes.Text));
            this.Close();
        }
    }
}
