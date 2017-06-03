using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UberFrba.Facturacion
{
    public class DataGridFacturacion
    {
         public string choferNombre { get; set; }

        public string choferApellido { get; set; }

        public decimal choferDNI { get; set; }
        public decimal cantidadKilomentro { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }

        public decimal Importe { get; set; }

        public DataGridFacturacion()
        {

        }
    }
}
