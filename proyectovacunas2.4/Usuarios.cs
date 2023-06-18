using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectovacunas2._4
{
    public partial class Usuarios : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=PCMASTERRACE\\SQLEXPRESS;Initial Catalog=WIMAXSA_BD;Integrated Security=true;");

        public Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void logear(string usuario, string contraseña)
        {
            try
            {
                cn.Open(); // Abre la conexión a la base de datos

                // Crea un nuevo objeto SqlCommand con una consulta SQL parametrizada
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuarios FROM usuarios " +
                    "WHERE usuario = @usuario AND Contraseña = @pas", cn);

                // Asigna los valores de los parámetros en la consulta SQL
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contraseña);

                SqlDataAdapter sda = new SqlDataAdapter(cmd); // Crea un SqlDataAdapter con el SqlCommand
                DataTable dt = new DataTable(); // Crea un DataTable para almacenar los resultados

                sda.Fill(dt); // Ejecuta la consulta y llena el DataTable con los resultados

                if (dt.Rows.Count == 1) // Comprueba si se encontró un usuario con los datos proporcionados
                {
                    //Bienvenida welcome = new Bienvenida(); // Crea una instancia del formulario Bienvenida
                    //welcome.Show(); // Muestra el formulario Bienvenida
                    this.Hide(); // Oculta el formulario actual

                    if (dt.Rows[0][1].ToString() == "Admin") // Comprueba el tipo de usuario
                    {
                        new frmPrincipal().Show(); // Crea una instancia del formulario frmPrincipal y lo muestra
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new frmPrincipal().Show(); // Crea una instancia del formulario frmPrincipal y lo muestra
                    }
                }
                else
                {
                    MessageBox.Show("Usuaio Y/O Contraseña Incorrecta"); // Muestra un mensaje de error si los datos son incorrectos
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); // Muestra un mensaje de excepción si ocurre un error
            }
            finally
            {
                cn.Close(); // Cierra la conexión a la base de datos en cualquier caso
            }
        }

        private void Contraseña_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // Set to no text.
            Contraseña_textBox2.Text = "";
            // The password character is an asterisk.
            Contraseña_textBox2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            Contraseña_textBox2.MaxLength = 14;
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            logear(Usuarios_textBox1.Text, Contraseña_textBox2.Text);
            Bienvenida welcome = new Bienvenida();
            welcome.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botonsalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
