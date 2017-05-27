using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Abm_Turno
{
    public class TurnoAltaModificacionData
    {
        public int? id { get; set; }
        public string descripcion { get; set; }
        public int horaInicio { get; set; }
        public int horaFin { get; set; }
        public decimal precioBase { get; set; }
        public decimal valorKilometro { get; set; }
        public bool habilitado { get; set; }

        //public AltaModificacionData(string nom, string ape, int dni, string mail, int tel, string dire, int cp, DateTime fechaNac)
        //{
        //    this.nombre = nom;
        //    this.apellido = ape;
        //    this.dni = dni;
        //    this.mail = mail;
        //    this.telefono = tel;
        //    this.direccion = dire;
        //    this.fechaNac = fechaNac;
        //    this.codigoPostal = cp;
        //}

        public TurnoAltaModificacionData()
        {

        }
    }
}
