using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Negocio
{
     class Reg_Vac
    {
        private string fecha;
        private string tipo_vacuna;
        private string rango_edades;
        private string fecha_administracion;
        private string fecha_siguiente_dosis;
        private string informacion_pasiente;

        public Reg_Vac()
        {
        }

        public Reg_Vac(string fecha, string tipo_vacuna, string rango_edades, string fecha_administracion, string fecha_siguiente_dosis, string informacion_pasiente)
        {
            this.fecha = fecha;
            this.tipo_vacuna = tipo_vacuna;
            this.rango_edades = rango_edades;
            this.fecha_administracion = fecha_administracion;
            this.fecha_siguiente_dosis = fecha_siguiente_dosis;
            this.informacion_pasiente = informacion_pasiente;
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string TipoVacuna
        {
            get { return tipo_vacuna; }
            set { tipo_vacuna = value; }
        }

        public string RangoEdades
        {
            get { return rango_edades; }
            set { rango_edades = value; }
        }

        public string FechaAdministracion
        {
            get { return fecha_administracion; }
            set { fecha_administracion = value; }
        }

        public string FechaSiguienteDosis
        {
            get { return fecha_siguiente_dosis; }
            set { fecha_siguiente_dosis = value; }
        }

        public string InformacionPasiente
        {
            get { return informacion_pasiente; }
            set { informacion_pasiente = value; }
        }
    }
}
