using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UberFrba.Rendicion_Viajes
{
    public class DataGridRendicion
    {
        public string clienteNombre { get; set; }

        public string clienteApellido { get; set; }

        public decimal clienteDNI { get; set; }
        public decimal cantidadKilomentro { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }

        public decimal Importe { get; set; }

        public DataGridRendicion()
        {

        }
    }
}
