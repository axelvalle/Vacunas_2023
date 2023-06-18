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
    public partial class Reporte : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            frmPrincipal p = new frmPrincipal();
            this.Close();
            p.Show();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string cadenasql = "SELECT * FROM Vacunacion";
            string[] reg = new string[8];

            registro.Rows.Clear();
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



                    registro.Rows.Add(reg[2], reg[1], reg[3], reg[5]);
                }

                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.cn.Close();
            }
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            registro.Rows.Clear();
        }
    }
}

