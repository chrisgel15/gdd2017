using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_ChoferCliente
{
    public partial class AltaModificacion : Form
    {

        #region Propiedades

        public IChoferCliente choferCliente { get; set; }

        private int id;

        #endregion

        #region Constructores

        public AltaModificacion(IChoferCliente c)
        {
            Inicializar(c);
            this.SetAltaHandler();
        }


        public AltaModificacion(IChoferCliente c, int id)
        {
            Inicializar(c);
            this.SetModificacionHandler();
            this.CompletaCamposActualizar(id);
        }
        #endregion

        #region Alta
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidaInfo())
                return;

            var nom = this.txtNombre.Text;
            var ape = this.txtApellido.Text;
            var dni = int.Parse(this.txtDni.Text);
            var mail = this.txtMail.Text;
            var telef = int.Parse(this.txtTelefono.Text);
            var direc = this.txtDireccion.Text;
            var cp = this.choferCliente.ValidarCodigoPostal ? int.Parse(this.txtCodPostal.Text) : 0;
            DateTime fecNac = DateTime.Parse(this.dtFechaNac.Text);


            var altaData = new AltaModificacionData(nom, ape, dni, mail, telef, direc, cp, fecNac);

            try
            {
                var nombreUsuarioCreado = this.choferCliente.Alta(altaData);
                this.lblError.Text = "El alta de " + this.choferCliente.Tipo + " ha sido exitosa. User: " + nombreUsuarioCreado + " Pass: " + nombreUsuarioCreado;
                this.LimpiaControles();
            }
            catch (ExisteClienteException ex)
            {
                this.lblError.Text = ex.Message;
            }
            catch (Exception ex)
            {
                this.lblError.Text = "Ha ocurrido un error en el Alta";
            }

        }

        private void CompletaCamposActualizar(int id)
        {
            AltaModificacionData modificacionData = this.choferCliente.CompletaCamposActualizar(id);

            this.txtNombre.Text = modificacionData.nombre;
            this.txtApellido.Text = modificacionData.apellido;
            this.txtDireccion.Text = modificacionData.direccion;
            this.txtDni.Text = modificacionData.dni.ToString();
            this.txtTelefono.Text = modificacionData.telefono.ToString();
            this.txtMail.Text = modificacionData.mail;
            this.txtCodPostal.Text = this.choferCliente.ValidarCodigoPostal ? modificacionData.codigoPostal.ToString() : "0";

            this.dtFechaNac.Value = modificacionData.fechaNac.Date;
            this.dtFechaNac.Text = modificacionData.fechaNac.Date.ToString();

            this.id = id;
        }
        #endregion

        #region Common

        private void Inicializar(IChoferCliente c)
        {
            InitializeComponent();
            LimpiaControles();
            this.choferCliente = c;
            this.groupBox1.Text = c.Tipo;
            this.txtCodPostal.Visible = c.HabilitarCodigoPostal;
            this.txtCodPostal.Text = c.HabilitarCodigoPostal ? String.Empty : "0";
            this.btnAceptar.Click -= btnAceptar_Click;
            this.btnAceptar.Click -= btnModificar_Click;
        }

        private void LimpiaControles()
        {
            this.txtNombre.Text = String.Empty;
            this.txtApellido.Text = String.Empty;
            this.txtDni.Text = String.Empty;
            this.txtTelefono.Text = String.Empty;
            this.txtDireccion.Text = String.Empty;
            this.txtMail.Text = String.Empty;
            this.txtCodPostal.Text = String.Empty;

            this.dtFechaNac.Text = DateTimeHelper.GetSystemDate().Date.ToString();
            this.dtFechaNac.Value = DateTimeHelper.GetSystemDate().Date;
            
            LimpiaErrores(this.txtNombre);
            LimpiaErrores(this.txtApellido);
            LimpiaErrores(this.txtDni);
            LimpiaErrores(this.txtTelefono);
            LimpiaErrores(this.txtDireccion);
            LimpiaErrores(this.dtFechaNac);
            LimpiaErrores(this.txtMail);
            LimpiaErrores(this.txtCodPostal);

        }

        private void LimpiaErrores(Control c)
        {
            this.errorProvider1.SetError(c, String.Empty);
        }

        private bool ValidaInfo()
        {
            // Tanto clientes como choferes...
            bool nomValido = ValidaRequerido(this.txtNombre);
            bool apeValido = ValidaRequerido(this.txtApellido);
            bool dniValido = ValidaRequerido(this.txtDni) && ValidaNumerico(this.txtDni);
            bool telValido = ValidaRequerido(this.txtTelefono) && ValidaNumerico(this.txtTelefono);
            bool direValida = ValidaRequerido(this.txtDireccion);
            bool fechaValida = ValidaRequerido(this.dtFechaNac);

            // Es requerido solo para choferes
            bool mailValido = this.choferCliente.ValidarMail ? ValidaRequerido(this.txtMail) : true;

            // Lo tienen solo los choferes, no los clientes.
            bool codPostalValido = this.choferCliente.ValidarCodigoPostal ?
                ValidaRequerido(this.txtCodPostal) && ValidaNumerico(this.txtCodPostal)
                : true;

            return nomValido && apeValido && dniValido && telValido && direValida && fechaValida && mailValido && codPostalValido;
        }

        private bool ValidaRequerido(Control c)
        {
            if (String.IsNullOrEmpty(c.Text))
                this.errorProvider1.SetError(c, "Este campo es requerido");
            else
                this.errorProvider1.SetError(c, String.Empty);

            return !String.IsNullOrEmpty(c.Text);
        }

        private bool ValidaNumerico(Control c)
        {

            if (!c.Text.All(Char.IsDigit))
                this.errorProvider1.SetError(c, "Este campo debe ser numerico.");
            else
                this.errorProvider1.SetError(c, String.Empty);

            return c.Text.All(Char.IsDigit);
        }

        public void SetAltaHandler()
        {
            this.btnAceptar.Click += btnAceptar_Click;
        }

        public void SetModificacionHandler()
        {
            this.btnAceptar.Click += btnModificar_Click;
        }
        #endregion

        #region Modificacion
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidaInfo())
                return;

            var modificacionData = new AltaModificacionData(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), 
                this.txtMail.Text, int.Parse(this.txtTelefono.Text), this.txtDireccion.Text, int.Parse(this.txtCodPostal.Text), DateTime.Parse(this.dtFechaNac.Text));

            modificacionData.id = this.id;

            try
            {
                this.choferCliente.Modificacion(modificacionData);
                this.lblError.Text = "La modificacion de " + this.choferCliente.Tipo + " ha sido exitosa";
                this.LimpiaControles();
            }
            catch (ExisteClienteException ex)
            {
                this.lblError.Text = ex.Message;
            }
            catch (Exception ex)
            {
                this.lblError.Text = "Ha ocurrido un error en la modificacion";
            }

        }
        #endregion
    }


}
