using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public interface IChoferCliente
    {
        #region Propiedades
        String Tipo { get;  }

        bool ValidarMail { get; }

        bool ValidarCodigoPostal { get; }

        bool HabilitarCodigoPostal { get; }
        #endregion

        void AbrirForm();

        string Alta(string nombre, string apellido, int dni, string mail, string direccion, int codPostal, DateTime fechaNac, int telefono);

        IList<GridData> Buscar(string busqueda);

        void Actualizar(int p);


        
    }
}
