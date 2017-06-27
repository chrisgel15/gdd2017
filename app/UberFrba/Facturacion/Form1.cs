using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Facturacion
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
            this.ddlCliente.Items.Clear();            

            this.dtInicio.Text = DateTimeHelper.GetSystemDate().ToString();
            this.dtInicio.Value = new DateTime(DateTimeHelper.GetSystemDate().Date.Year, DateTimeHelper.GetSystemDate().Date.Month, 1);

            this.dtInicio.Format = DateTimePickerFormat.Custom;
            this.dtInicio.CustomFormat = "MMM-yyyy";
            this.dtInicio.ShowUpDown = true;

        }

        private void LimpiaErrores()
        {
            this.lblError.Text = String.Empty;
            LimpiaErrores(this.ddlCliente);
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
                this.ddlCliente.Items.Add("-- Seleccione --");
                var clientes = dbCtx.CLIENTES.Where(c => c.HABIILITADO).ToArray();

                this.ddlCliente.Items.AddRange(clientes);

                this.ddlCliente.ValueMember = "ID_CLIENTE";
                this.ddlCliente.DisplayMember = "NOMBRE";
                this.ddlCliente.SelectedIndex = 0;

          
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;

            LimpiaErrores();

            var clienteValido = ValidaDDLRequerido(this.ddlCliente);

            bool fechasValidas = false;

            if (clienteValido)
                fechasValidas = ValidaFechas();

            if (fechasValidas)
            {
                AgregarFacturacion();
            }
        }

        private void AgregarFacturacion()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var idCliente = ((CLIENTE)ddlCliente.SelectedItem).ID_CLIENTE;

                decimal importeViajes = 0;

                var mesSiguiente = dtInicio.Value.Date.AddMonths(1);

                var viajesDelCliente = dbCtx.VIAJES.Where(v => v.CLIENTE_ID == idCliente && v.FECHA_INICIO >= dtInicio.Value.Date && v.FECHA_INICIO < mesSiguiente).ToList();

                var listaViajes = new List<DataGridFacturacion>();

                foreach (VIAJE vi in viajesDelCliente)
                {
                    var precioBase = dbCtx.TURNOS.Where(t => t.ID_TURNO == vi.TURNO_ID).FirstOrDefault().PRECIO_BASE;
                    var precioKm = dbCtx.TURNOS.Where(t => t.ID_TURNO == vi.TURNO_ID).FirstOrDefault().VALOR_KM;
                    var cantidadKm = vi.CANTIDAD_KM;

                    importeViajes += precioBase + precioKm * cantidadKm;

                    listaViajes.Add(new DataGridFacturacion{ 
                        choferNombre = vi.CHOFERE.NOMBRE, 
                        cantidadKilomentro = vi.CANTIDAD_KM,
                        fechaInicio = vi.FECHA_INICIO, 
                        fechaFin = vi.FECHA_FIN, 
                        Importe = precioBase + precioKm*cantidadKm,
                        choferApellido = vi.CHOFERE.APELLIDO,
                        choferDNI = vi.CHOFERE.DNI
                    });

                }

                FACTURA f = new FACTURA()
                {
                    CLIENTE_ID = idCliente,
                    FECHA_FACT = DateTime.Now,
                    VIAJES = dbCtx.VIAJES.Where(v => v.CLIENTE_ID == idCliente && v.FECHA_INICIO >= dtInicio.Value.Date && v.FECHA_INICIO < mesSiguiente).ToList(),
                    IMPORTE = importeViajes,
                    FECHA_INICIO = dtInicio.Value.Date,
                    FECHA_FIN = dtInicio.Value.Date.AddMonths(1),
                    NUMERO = dbCtx.FACTURAS.Max(n => n.NUMERO) + 1                    
                };

                try
                {
                    dbCtx.FACTURAS.Add(f);
                    dbCtx.SaveChanges();
                    this.lblError.Text = "Se ha generado la factura por $ " + importeViajes.ToString();

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
                    this.lblError.Text = "Ocurrio un error al agregar la factura";
                }
            }

            LimpiaControles();
            LlenarCombos();
        }

        private bool ValidaFechas()
        {
            var cliente = (CLIENTE)this.ddlCliente.SelectedItem;

            if (this.dtInicio.Value.Year <= 2015)
            {
                this.errorProvider1.SetError(dtInicio, "No se permiten fechas anteriores a 2016 debido a la migracion al nuevo sistema");
                return false;
            }

            using(var dbCtx = new GD1C2017Entities())
            {

                var mesSiguiente = dtInicio.Value.Date.AddMonths(1);

                if (!dbCtx.VIAJES.Any(v => v.CLIENTE_ID == cliente.ID_CLIENTE && v.FECHA_INICIO >= dtInicio.Value.Date && v.FECHA_INICIO < mesSiguiente))
                {
                    this.errorProvider1.SetError(dtInicio, "El cliente no tiene viajes en el mes elegido.");
                    return false;
                }

                if (dbCtx.FACTURAS.Any(f => f.FECHA_INICIO == this.dtInicio.Value.Date && f.CLIENTE_ID == cliente.ID_CLIENTE))
                {
                    this.lblError.Text = "Ya se ha realizado una factura para este mes y para este cliente";
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
