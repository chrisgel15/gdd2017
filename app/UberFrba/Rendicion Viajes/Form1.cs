using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Rendicion_Viajes
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
            this.ddlTurno.Items.Clear();

            //this.dtInicio.Text = DateTime.Now.ToString();
            //this.dtInicio.Value = DateTime.Now;

            this.dtInicio.Text = DateTimeHelper.GetSystemDate().ToString();
            this.dtInicio.Value = DateTimeHelper.GetSystemDate();

            this.dtInicio.Format = DateTimePickerFormat.Short; 

        }

        private void LimpiaErrores()
        {
            this.lblError.Text = String.Empty;
            LimpiaErrores(this.ddlChofer);
            LimpiaErrores(this.ddlTurno);
            LimpiaErrores(this.dtInicio);
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

                this.ddlTurno.Items.Add("-- Seleccione --");
                var turnos = dbCtx.TURNOS.Where(c => c.HABILITADO).ToArray();

                this.ddlTurno.Items.AddRange(turnos);

                this.ddlTurno.ValueMember = "ID_TURNO";
                this.ddlTurno.DisplayMember = "DESCRIPCION";
                this.ddlTurno.SelectedIndex = 0;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;

            LimpiaErrores();

            var choferValido = ValidaDDLRequerido(this.ddlChofer);
            var turnoValido = ValidaDDLRequerido(this.ddlTurno);

            bool fechasValidas = false;

            if (choferValido)
                fechasValidas = ValidaFechas();

            if (fechasValidas && turnoValido)
            {
                AgregarRendicion();
            }
        }

        private void AgregarRendicion()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var idChofer = ((CHOFERE)ddlChofer.SelectedItem).ID_CHOFER;

                decimal importeViajes = 0;

                var diaDespues = dtInicio.Value.Date.AddDays(1);

                var viajesDelChofer = dbCtx.VIAJES.Where(v => v.CHOFER_ID == idChofer && v.FECHA_INICIO >= dtInicio.Value.Date && v.FECHA_INICIO < diaDespues).ToList();

                var listaViajes = new List<DataGridRendicion>();

                foreach(VIAJE vi in viajesDelChofer)
                {
                    var precioBase = dbCtx.TURNOS.Where(t => t.ID_TURNO == vi.TURNO_ID).FirstOrDefault().PRECIO_BASE;
                    var precioKm = dbCtx.TURNOS.Where(t => t.ID_TURNO == vi.TURNO_ID).FirstOrDefault().VALOR_KM;
                    var cantidadKm = vi.CANTIDAD_KM;

                    importeViajes += precioBase + precioKm * cantidadKm;

                    listaViajes.Add(new DataGridRendicion{ 
                        clienteNombre = vi.CLIENTE.NOMBRE, 
                        cantidadKilomentro = vi.CANTIDAD_KM,
                        fechaInicio = vi.FECHA_INICIO, 
                        fechaFin = vi.FECHA_FIN, 
                        Importe = precioBase + precioKm*cantidadKm,
                        clienteApellido = vi.CLIENTE.APELLIDO,
                        clienteDNI = vi.CLIENTE.DNI
                    });

                }

                RENDICIONE r = new RENDICIONE()
                {
                    CHOFER_ID = idChofer,
                    TURNO_ID = ((TURNO)ddlTurno.SelectedItem).ID_TURNO,
                    VIAJES = dbCtx.VIAJES.Where(v => v.CHOFER_ID == idChofer && v.FECHA_INICIO >= dtInicio.Value.Date && v.FECHA_INICIO < diaDespues).ToList(),
                    IMPORTE = importeViajes * (decimal)0.3,
                    FECHA = this.dtInicio.Value.Date,
                    NUMERO = dbCtx.RENDICIONES.Max(n => n.NUMERO) + 1
                };

                try
                {
                    dbCtx.RENDICIONES.Add(r);
                    dbCtx.SaveChanges();
                    this.lblError.Text = "Se ha generado la rendicion por $ " + importeViajes.ToString();

                    if (listaViajes.Count > 0)
                    {
                        this.dataGridView1.Visible = true;
                        this.dataGridView1.DataSource = listaViajes;
                    }
                    else
                        this.dataGridView1.Visible = false;                  
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
            var chofer = (CHOFERE)this.ddlChofer.SelectedItem;

            if (this.dtInicio.Value.Year <= 2015)
            {
                this.errorProvider1.SetError(dtInicio, "No se permiten fechas anteriores a 2016 debido a la migracion al nuevo sistema");
                return false;
            }

            using(var dbCtx = new GD1C2017Entities())
            {

                var diaDespues = dtInicio.Value.Date.AddDays(1);

                if (!dbCtx.VIAJES.Any(v => v.CHOFER_ID == chofer.ID_CHOFER && v.FECHA_INICIO >= dtInicio.Value.Date && v.FECHA_INICIO < diaDespues))
                {
                    this.errorProvider1.SetError(dtInicio, "El chofer no tiene viajes en la fecha elegida.");
                    return false;
                }

                if (dbCtx.RENDICIONES.Any(r => r.FECHA == this.dtInicio.Value.Date && r.CHOFER_ID == chofer.ID_CHOFER))
                {
                    this.lblError.Text = "Ya se ha realizado una rendicion para esta fecha y para este chofer";
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
