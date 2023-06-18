using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Negocio
{
    class Paciente : Personas
    {
        private string enfermedad_padece;

        public Paciente(string nombre, string apellido, byte edad, string departamento, string direccion)
            : base(nombre, apellido, edad, departamento, direccion)
        {
            enfermedad_padece = "";
        }

        public string EnfermedadPadece
        {
            get { return enfermedad_padece; }
            set { enfermedad_padece = value; }
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
        }

    }
}

