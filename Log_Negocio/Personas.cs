using System;
using System.Windows.Forms;

namespace Log_Negocio
{
    class Personas
    {
        private string nombre;
        private string apellido;
        private byte edad;
        private string departamento;
        private string direccion;

        public Personas()
        {
        }

        public Personas(string nombre, string apellido, byte edad, string departamento, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.departamento = departamento;
            this.direccion = direccion;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public byte Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public virtual void mostrarDatos()
        {
            MessageBox.Show(nombre + apellido + edad + departamento + direccion + "\n");
        }
    }
}

