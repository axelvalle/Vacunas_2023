using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaBD
{
    public class ConexionBD
    {

        public SqlConnection cn;
        public SqlCommand cmd;
        public SqlDataReader rd;
        public string mensaje = "";

        //ejecutar la conexion a la base de datos
        public ConexionBD()
        {
            try
            {
                cn = new SqlConnection("Data Source=PCMASTERRACE\\SQLEXPRESS;Initial Catalog=WIMAXSA_BD;Integrated Security=true;");
                mensaje = "Conexión exitosa";
            }
            catch (Exception ex)
            {
                mensaje = "Error, conexión fallida: " + ex.Message;


            }


        }

        //metodos de la tabla de empleados
        public string Insertar_Empleado(string nombre, int edad, string departamento, string direccion, string cargo)
        {
            string cadena = "INSERT INTO Empleado (Nombre, Edad, Departamento, Direccion, Cargo) VALUES " +
                "('" + nombre + "', '" + edad + "', '" + departamento + "', '" + direccion + "', '" + cargo + "')";


            try
            {
                cn.Open();
                cmd = new SqlCommand(cadena, cn);
                cmd.ExecuteNonQuery();
                mensaje = "Los datos se han insertado exitosamente";
                cn.Close();

            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                cn.Close();
            }
            return mensaje;
        }

        public string Eliminar_Empleado(string dato)
        {
            string cadena = "DELETE FROM Empleado WHERE Nombre = '" + dato + "'";

            try
            {
                cn.Open();
                cmd = new SqlCommand(cadena, cn);
                cmd.ExecuteNonQuery();
                mensaje = "Los datos se han eliminado exitosamente";
                cn.Close();
            }
            catch (Exception ex)
            {

                mensaje = "el nombre que buscas no se ha encontrado";
                cn.Close();
            }
            return mensaje;
        }


        //metodos de la tabla registro de vacuna

        public string Insertar_Vacuna(string nombreVacuna, string tipo, string dosis, string fechaVencimiento, string informacionVacuna, string efectos)
        {
            string cadena = "INSERT INTO Registro_Vacuna (Nombre_De_La_Vacuna, Tipo, Dosis, Fecha_De_Vencimiento, Informacion_De_La_Vacuna, Efectos) VALUES " +
                "('" + nombreVacuna + "', '" + tipo + "', '" + dosis + "', '" + fechaVencimiento + "', '" + informacionVacuna + "', '" + efectos + "')";

            try
            {
                cn.Open();
                cmd = new SqlCommand(cadena, cn);
                cmd.ExecuteNonQuery();
                mensaje = "Los datos se han insertado exitosamente";
                cn.Close();
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                cn.Close();
            }
            return mensaje;
        }

        public string Eliminar_Vacuna(string nombreVacuna)
        {
            string cadena = "DELETE FROM Registro_Vacuna WHERE Nombre_De_La_Vacuna = '" + nombreVacuna + "'";

            try
            {
                cn.Open();
                cmd = new SqlCommand(cadena, cn);
                cmd.ExecuteNonQuery();
                mensaje = "Los datos se han eliminado exitosamente";
                cn.Close();
            }
            catch (Exception ex)
            {
                mensaje = "La vacuna que buscas no se ha encontrado";
                cn.Close();
            }
            return mensaje;
        }

        //metodo de vacunacion

        public string Insertar_Paciente(string nombrePaciente, string edadPaciente, string direccion, string enfermedad, string vacunaAplicada, string fechaPrimeraDosis, string fechaSegundaDosis, string observaciones)
        {
            string cadena = "INSERT INTO Vacunacion (Nombre_Del_Paciente, Edad_Del_Paciente, Direccion, Enfermedad, Vacuna_Aplicada, Fecha_Primera_Dosis, Fecha_Segunda_Dosis, Observaciones) VALUES " +
                "('" + nombrePaciente + "', '" + edadPaciente + "', '" + direccion + "', '" + enfermedad + "', '" + vacunaAplicada + "', '" + fechaPrimeraDosis + "', '" + fechaSegundaDosis + "', '" + observaciones + "')";

            try
            {
                cn.Open();
                cmd = new SqlCommand(cadena, cn);
                cmd.ExecuteNonQuery();
                mensaje = "Los datos se han insertado exitosamente";
                cn.Close();
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                cn.Close();
            }
            return mensaje;
        }

        public string Eliminar_Paciente(string nombrePaciente)
        {
            string cadena = "DELETE FROM Vacunacion WHERE Nombre_Del_Paciente = '" + nombrePaciente + "'";

            try
            {
                cn.Open();
                cmd = new SqlCommand(cadena, cn);
                cmd.ExecuteNonQuery();
                mensaje = "Los datos se han eliminado exitosamente";
                cn.Close();
            }
            catch (Exception ex)
            {
                mensaje = "El paciente que buscas no se ha encontrado";
                cn.Close();
            }
            return mensaje;
        }

        


    }
}
