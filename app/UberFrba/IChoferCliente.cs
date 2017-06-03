using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_ChoferCliente;

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

        string Alta(AltaModificacionData data);

        IList<GridData> Buscar(string busquedaApellido, string busquedaNombre, string busquedaDni);

        void Habilitar(int id);

        void AbrirFormActualizar(int p);

        AltaModificacionData CompletaCamposActualizar(int id);

        void Modificacion(AltaModificacionData modificacionData);
    }
}
