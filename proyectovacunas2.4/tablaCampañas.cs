using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyectovacunas2._4
{
    public partial class tablaCampañas : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        public tablaCampañas()
        {
            InitializeComponent();
        }

        private void tablaCampañas_Load(object sender, EventArgs e)
        {
            string cadenasql = "SELECT * FROM Campaña_De_Vacunacion";
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
            catch (Exception ex) { }
        }
    }
}
