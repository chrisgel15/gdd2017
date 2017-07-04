using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Abm_ChoferCliente
{
    public class AltaModificacionData
    {
        public int? id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int? codigoPostal { get; set; }
        public DateTime fechaNac { get; set; }

        public AltaModificacionData(string nom, string ape, int dni, string mail, int tel, string dire, int cp, DateTime fechaNac)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = dni;
            this.mail = mail;
            this.telefono = tel;
            this.direccion = dire;
            this.fechaNac = fechaNac;
            this.codigoPostal = cp;
        }

        public AltaModificacionData()
        {

        }
    }
}
