using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Log_Negocio
{
    class Empleados : Personas
    {
        private string cargo;
        private string area_laboral;

        public Empleados(string cargo, string area_laboral)
        {
            this.cargo = cargo;
            this.area_laboral = area_laboral;
        }

        public Empleados(string nombre, string apellido, byte edad, string departamento, string direccion) : base(nombre, apellido, edad, departamento, direccion)
        {

        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public string AreaLaboral
        {
            get { return area_laboral; }
            set { area_laboral = value; }
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            MessageBox.Show("Hola Mundo");
        }
    }
}

