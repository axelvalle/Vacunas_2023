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
    public partial class frmEliminarVacuna : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        public frmEliminarVacuna()
        {
            InitializeComponent();
        }

        private void frmEliminarVacuna_Load(object sender, EventArgs e)
        {
            string cadenasql = "SELECT * FROM Registro_Vacuna";
            string[] reg = new string[1];

            cbVacunas.Items.Clear();
            try
            {
                con.cn.Open();
                con.cmd = new System.Data.SqlClient.SqlCommand(cadenasql, con.cn);
                con.rd = con.cmd.ExecuteReader();

                while (con.rd.Read())
                {
                    reg[0] = con.rd[0].ToString();


                    cbVacunas.Items.Add(reg[0]);
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
            MessageBox.Show(con.Eliminar_Vacuna(cbVacunas.Text));
            this.Close();
        }

        private void cbVacunas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
