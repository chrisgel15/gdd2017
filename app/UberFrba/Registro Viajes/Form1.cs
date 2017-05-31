using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Registro_Viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LimpiaControles();
            LlenarCombos();
        }

        private void LimpiaControles()
        {
            this.ddlChofer.Items.Clear();
            this.ddlAuto.Items.Clear();
            this.ddlTurno.Items.Clear();
            this.ddlCliente.Items.Clear();

            this.txtKilometros.Value = 0;

            this.dtInicio.Text = DateTime.Now.ToString();
            this.dtInicio.Value = DateTime.Now;

            this.dtFin.Text = DateTime.Now.ToString();
            this.dtFin.Value = DateTime.Now;

            this.dtInicio.Format = DateTimePickerFormat.Custom;
            this.dtInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            this.dtFin.Format = DateTimePickerFormat.Custom;
            this.dtFin.CustomFormat = "dd/MM/yyyy hh:mm:ss"; 

            this.lblError.Text = String.Empty;

            LimpiaErrores(this.ddlChofer);
            LimpiaErrores(this.ddlAuto);
            LimpiaErrores(this.ddlTurno);
            LimpiaErrores(this.ddlCliente);
            LimpiaErrores(this.txtKilometros);
            LimpiaErrores(this.dtInicio);
            LimpiaErrores(this.dtFin);

        }

        private void LimpiaErrores(Control c)
        {
            this.errorProvider1.SetError(c, String.Empty);
        }

        private void LlenarCombos()
        {
            using(var dbCtx = new GD1C2017Entities())
            {
                this.ddlChofer.Items.Add("-- Seleccione --");
                var choferes = dbCtx.CHOFERES.Where(c => c.HABILITADO).ToArray();

                this.ddlChofer.Items.AddRange(choferes);

                this.ddlChofer.ValueMember = "ID_CHOFER";
                this.ddlChofer.DisplayMember = "NOMBRE";
                this.ddlChofer.SelectedIndex = 0;


                this.ddlCliente.Items.Add("-- Seleccione --");
                var clientes = dbCtx.CHOFERES.Where(c => c.HABILITADO).ToArray();

                this.ddlCliente.Items.AddRange(choferes);

                this.ddlCliente.ValueMember = "ID_CLIENTE";
                this.ddlCliente.DisplayMember = "NOMBRE";
                this.ddlCliente.SelectedIndex = 0;
              

                
            }

            this.ddlAuto.Enabled = false;
            this.ddlTurno.Enabled = false;
        }

        private void ddlChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlAuto.Items.Clear();
            this.ddlTurno.Items.Clear();
            this.ddlTurno.Enabled = false;

            if (ddlChofer.SelectedIndex > 0)
            {
                var chof = (CHOFERE)ddlChofer.SelectedItem;

                using(var dbCtx = new GD1C2017Entities())
                {
                    var autos = dbCtx.AUTOS.Where(a => a.CHOFER_ID == chof.ID_CHOFER && a.HABILITADO).ToArray();
                    if (autos != null)
                    {
                        this.ddlAuto.Items.Add("-- Seleccione -- ");
                        this.ddlAuto.Items.AddRange(autos);
                        this.ddlAuto.Enabled = true;
                        this.ddlAuto.ValueMember = "ID_AUTO";
                        this.ddlAuto.DisplayMember = "PATENTE";
                        this.ddlAuto.SelectedIndex = 0;
                    }
                    else
                        this.lblError.Text = "El chofer seleccionado no posee autos";
                }
            }
            else
            {               
                this.ddlAuto.Enabled = false;
            }

           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var choferValido = ValidaDDLRequerido(this.ddlChofer);
            var clienteValido = ValidaDDLRequerido(this.ddlCliente);
            var autoValido = ValidaDDLRequerido(this.ddlAuto);
            var distanciaValida = ValidaDistancia(this.txtKilometros);
        }

        private bool ValidaDDLRequerido(ComboBox c)
        {
            if (c.SelectedIndex < 1) // El combo esta vacio o seleccionado el indice 0
                this.errorProvider1.SetError(c, "Este campo es requerido");
            else
                this.errorProvider1.SetError(c, String.Empty);

            return c.SelectedIndex > 0;
        }

        private bool ValidaDistancia(NumericUpDown n)
        {
            if (n.Value < 1) // El combo esta vacio o seleccionado el indice 0
                this.errorProvider1.SetError(n, "Este campo es requerido");
            else
                this.errorProvider1.SetError(n, String.Empty);

            return n.Value > 0;
        }
    }
}
