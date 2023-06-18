using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Negocio
{
    class Centro_De_Salud
    {
        private string nombre;
        private string direccion;
        private string telefonos;

        public Centro_De_Salud()
        {
        }

        public Centro_De_Salud(string nombre, string direccion, string telefonos)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefonos = telefonos;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }
    }
}

