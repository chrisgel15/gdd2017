﻿using System;
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

        #endregion

        #region Constructores

        //public AltaModificacion()
        //{
        //    InitializeComponent();
        //    LimpiaControles();
        //}

        public AltaModificacion(IChoferCliente c)
        {
            Inicializar(c);
            this.SetAltaHandler();
        }

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

        public AltaModificacion(IChoferCliente c, int id)
        {
            Inicializar(c);
            this.SetModificacionHandler();
            this.CompletaCamposActualizar(id);
        }

        public void SetAltaHandler()
        {
            this.btnAceptar.Click += btnAceptar_Click;
        }

        public void SetModificacionHandler()
        {
            this.btnAceptar.Click += btnModificar_Click;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidaInfo())
                return;
        }

        #endregion

        #region Alta
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidaInfo())
                return;

            var altaData = new AltaModificacionData(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text),
                this.txtMail.Text, int.Parse(this.txtTelefono.Text), this.txtDireccion.Text, int.Parse(this.txtCodPostal.Text), DateTime.Parse(this.dtFechaNac.Text));

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
                this.lblError.Text = "Ha ocurrido un error";
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
            
            
        }
        #endregion

        #region Common
        private void LimpiaControles()
        {
            this.txtNombre.Text = String.Empty;
            this.txtApellido.Text = String.Empty;
            this.txtDni.Text = String.Empty;
            this.txtTelefono.Text = String.Empty;
            this.txtDireccion.Text = String.Empty;
            //this.dtFechaNac.Text = String.Empty;
            this.txtMail.Text = String.Empty;
            this.txtCodPostal.Text = String.Empty;

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
        #endregion
    }

   
}
