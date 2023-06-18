using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Negocio
{
    class Vacunas
    {
        private string nombre;
        private string tipo;
        private string dosis;
        private string fecha_de_vencimiento;
        private string informacion_de_la_Vacuna;
        private string contraindicaciones;
        private string efectos;
        private int edad_paciente;

        public Vacunas()
        {
        }

        public Vacunas(string nombre, string tipo, string dosis, string fecha_de_vencimiento, string informacion_de_la_Vacuna, string contraindicaciones, string efectos, int edad_paciente)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.dosis = dosis;
            this.fecha_de_vencimiento = fecha_de_vencimiento;
            this.informacion_de_la_Vacuna = informacion_de_la_Vacuna;
            this.contraindicaciones = contraindicaciones;
            this.efectos = efectos;
            this.edad_paciente = edad_paciente;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Dosis
        {
            get { return dosis; }
            set { dosis = value; }
        }

        public string FechaDeVencimiento
        {
            get { return fecha_de_vencimiento; }
            set { fecha_de_vencimiento = value; }
        }

        public string InformacionDeLaVacuna
        {
            get { return informacion_de_la_Vacuna; }
            set { informacion_de_la_Vacuna = value; }
        }

        public string Contraindicaciones
        {
            get { return contraindicaciones; }
            set { contraindicaciones = value; }
        }

        public string Efectos
        {
            get { return efectos; }
            set { efectos = value; }
        }

        public int EdadPaciente
        {
            get { return edad_paciente; }
            set { edad_paciente = value; }
        }
    }
}

