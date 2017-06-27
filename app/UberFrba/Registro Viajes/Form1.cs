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
            LimpiaErrores();
            LlenarCombos();
        }

        private void LimpiaControles()
        {
            this.ddlChofer.Items.Clear();
            this.ddlAuto.Items.Clear();
            this.ddlTurno.Items.Clear();
            this.ddlCliente.Items.Clear();

            this.txtKilometros.Value = 0;

            this.dtInicio.Text = DateTimeHelper.GetSystemDate().ToString();
            this.dtInicio.Value = DateTimeHelper.GetSystemDate();

            this.dtFin.Text = DateTimeHelper.GetSystemDate().ToString();
            this.dtFin.Value = DateTimeHelper.GetSystemDate();

            this.dtInicio.Format = DateTimePickerFormat.Custom;
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            this.dtFin.Format = DateTimePickerFormat.Custom;
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm:ss"; 
         

        }

        private void LimpiaErrores()
        {
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
                var clientes = dbCtx.CLIENTES.Where(c => c.HABIILITADO).ToArray();

                this.ddlCliente.Items.AddRange(clientes);

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

        private void ddlAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlTurno.Items.Clear();
            ddlTurno.Enabled = false;

            if (ddlAuto.SelectedIndex > 0)
            {
                var auto = (AUTO)ddlAuto.SelectedItem;

                using (var dbCtx = new GD1C2017Entities())
                {
                    var turnos = dbCtx.TURNOS.Where(t => t.AUTOS.Any(a => a.ID_AUTO == auto.ID_AUTO) && t.HABILITADO).ToArray();
                    if (turnos != null)
                    {
                        this.ddlTurno.Items.Add("-- Seleccione -- ");
                        this.ddlTurno.Items.AddRange(turnos);
                        this.ddlTurno.Enabled = true;
                        this.ddlTurno.ValueMember = "ID_NOMBRE";
                        this.ddlTurno.DisplayMember = "DESCRIPCION";
                        this.ddlTurno.SelectedIndex = 0;
                    }
                    else
                        this.lblError.Text = "El auto seleccionado no posee turnos asignados";

                }
            }
            else
                this.ddlTurno.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LimpiaErrores();

            var choferValido = ValidaDDLRequerido(this.ddlChofer);
            var clienteValido = ValidaDDLRequerido(this.ddlCliente);
            var autoValido = ValidaDDLRequerido(this.ddlAuto);
            var turnoValido = ValidaDDLRequerido(this.ddlTurno);
            var distanciaValida = ValidaDistancia(this.txtKilometros);

            bool fechasValidas = false;

            if (choferValido && clienteValido)
                fechasValidas = ValidaFechas();

            if (fechasValidas && autoValido && turnoValido && distanciaValida)
            {
                AgregarViaje();
            }
        }

        private void AgregarViaje()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                VIAJE v = new VIAJE()
                {
                    AUTO_ID = ((AUTO)ddlAuto.SelectedItem).ID_AUTO,
                    CHOFER_ID = ((CHOFERE)ddlChofer.SelectedItem).ID_CHOFER,
                    CLIENTE_ID = ((CLIENTE)ddlCliente.SelectedItem).ID_CLIENTE,
                    TURNO_ID = ((TURNO)ddlTurno.SelectedItem).ID_TURNO,
                    CANTIDAD_KM = this.txtKilometros.Value,
                    FECHA_INICIO = this.dtInicio.Value,
                    FECHA_FIN = this.dtFin.Value
                };

                try
                {
                    dbCtx.VIAJES.Add(v);
                    dbCtx.SaveChanges();
                    this.lblError.Text = "El viaje se ha agregado con exito";


                }
                catch (Exception ex)
                {
                    this.lblError.Text = "Ocurrio un error al agregar el viaje";
                }
            }

            LimpiaControles();
            LlenarCombos();
        }

        private bool ValidaFechas()
        {
            if(this.dtInicio.Value >= this.dtFin.Value)
            {
                this.errorProvider1.SetError(dtInicio, "La fecha inicio no puede ser mayor ni iguala la fecha fin");
                this.errorProvider1.SetError(dtFin, "La fecha inicio no puede ser mayor ni igual a la fecha fin");
                return false;
            }

            var cliente = (CLIENTE)this.ddlCliente.SelectedItem;
            var chofer = (CHOFERE)this.ddlChofer.SelectedItem;

            


            using(var dbCtx = new GD1C2017Entities())
            {
                var viajes = dbCtx.VIAJES.Where(v => v.CLIENTE_ID == cliente.ID_CLIENTE && dtInicio.Value >= v.FECHA_INICIO && dtInicio.Value <= v.FECHA_FIN && v.FECHA_FIN != null);

                foreach (VIAJE v in viajes)
                {
                    if (v.FECHA_FIN != null)
                    {
                        bool b1 = dtInicio.Value >= v.FECHA_INICIO;
                        bool b2 = dtInicio.Value <= v.FECHA_FIN;
                    }
                }


                if (dbCtx.VIAJES.Any(v => v.CLIENTE_ID == cliente.ID_CLIENTE && dtInicio.Value >= v.FECHA_INICIO && dtInicio.Value <= v.FECHA_FIN && v.FECHA_FIN != null))
                {
                    this.errorProvider1.SetError(dtInicio, "El cliente tiene un viaje en esa fecha de inicio");
                    return false;
                }

                if (dbCtx.VIAJES.Any(v => v.CLIENTE_ID == cliente.ID_CLIENTE && dtFin.Value >= v.FECHA_INICIO && dtFin.Value <= v.FECHA_FIN && v.FECHA_FIN != null))
                {
                    this.errorProvider1.SetError(dtFin, "El cliente tiene un viaje en esa fecha de Fin");
                    return false;
                }

                if (dbCtx.VIAJES.Any(v => v.CHOFER_ID == chofer.ID_CHOFER && dtInicio.Value >= v.FECHA_INICIO && dtInicio.Value <= v.FECHA_FIN && v.FECHA_FIN != null))
                {
                    this.errorProvider1.SetError(dtInicio, "El chofer tiene un viaje en esa fecha de inicio");
                    return false;
                }

                if (dbCtx.VIAJES.Any(v => v.CHOFER_ID == chofer.ID_CHOFER && dtFin.Value >= v.FECHA_INICIO && dtFin.Value <= v.FECHA_FIN && v.FECHA_FIN != null))
                {
                    this.errorProvider1.SetError(dtFin, "El chofer tiene un viaje en esa fecha de Fin");
                    return false;
                }
            }

            return true;
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
