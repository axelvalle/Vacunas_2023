using Administracion_de_vacunas;
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
    public partial class frmInformacion : Form
    {
        CapaBD.ConexionBD con = new CapaBD.ConexionBD();
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmvacunacion r = new frmvacunacion();
            r.Show();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            string cadenasql = "SELECT * FROM Vacunacion";
            string[] reg = new string[8];

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
                    reg[6] = con.rd[6].ToString();
                    reg[7] = con.rd[7].ToString();


                    Tabla.Rows.Add(reg[0], reg[1], reg[2], reg[3], reg[4], reg[5], reg[6], reg[7]);
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
            frmEliminarPaciente eliminarPaciente = new frmEliminarPaciente();
            eliminarPaciente.ShowDialog();
        }
    }
}
