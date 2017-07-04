using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno
{
    public partial class AltaModificacion : Form
    {
        #region Propiedades

        private int id;

        #endregion

        #region Constructores

        public AltaModificacion()
        {
            Inicializar();
            this.SetAltaHandler();
        }


        public AltaModificacion(int id)
        {
            Inicializar();
            this.SetModificacionHandler();
            this.CompletaCamposActualizar(id);
        }
        #endregion

        #region Alta
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidaInfo())
                return;

            try
            {
                this.Alta(this.txtDescripcion.Text, this.txtHoraInicio.Value, this.txtHoraFin.Value,
                    this.txtPrecioBase.Value, this.txtValorKilometro.Value, this.chkHabilitado.Checked);
                this.lblError.Text = "El alta de turno ha sido exitosa";
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

        private void Alta(string desc, decimal horaInicio, decimal horaFin, decimal precioBase, decimal valorKm, bool habilitado)
        {
            TURNO nuevoTurno = new TURNO()
            {
                DESCRIPCION = desc,
                HORA_INICIO = horaInicio,
                HORA_FIN = horaFin,
                PRECIO_BASE = precioBase,
                VALOR_KM = valorKm,
                HABILITADO = habilitado
            };            

            using(var dbCtx = new GD1C2017Entities())
            {
                ValidacionesTurno(horaInicio, horaFin, nuevoTurno, dbCtx);

                dbCtx.TURNOS.Add(nuevoTurno);
                dbCtx.SaveChanges();
            }
        }

        private static void ValidacionesTurno(decimal horaInicio, decimal horaFin, TURNO turno, GD1C2017Entities dbCtx)
        {
            if (dbCtx.TURNOS.Any(t => t.DESCRIPCION.ToUpper() == turno.DESCRIPCION.ToUpper() && turno.ID_TURNO != t.ID_TURNO))
                throw new ExisteClienteException("Ya existe un turno con ese nombre");

            if (horaInicio > horaFin)
                throw new ExisteClienteException("La hora inicio no puede ser mayor a la hora fin");

            if(horaInicio == horaFin)
                throw new ExisteClienteException("La hora inicio no puede ser igual a la hora fin");

            // El chequeo de la superposicion de turnos se realiza solo si 
            if (turno.HABILITADO)
            {
                if (dbCtx.TURNOS.Any(t => t.HORA_INICIO <= turno.HORA_INICIO && t.HORA_FIN > turno.HORA_INICIO && t.HABILITADO && t.ID_TURNO != turno.ID_TURNO))
                    throw new ExisteClienteException("La hora de INICIO se superpone con otro turno");

                if (dbCtx.TURNOS.Any(t => t.HORA_INICIO < turno.HORA_FIN && t.HORA_FIN >= turno.HORA_FIN && t.HABILITADO && t.ID_TURNO != turno.ID_TURNO))
                    throw new ExisteClienteException("La hora de FIN se superpone con otro turno");
            }
        }


        private void CompletaCamposActualizar(int id)
        {
            TURNO turno;
            using (var dbCtx = new GD1C2017Entities())
            {
                turno = dbCtx.TURNOS.First(t => t.ID_TURNO == id);

                this.txtDescripcion.Text = turno.DESCRIPCION;
                this.txtHoraInicio.Value = turno.HORA_INICIO;
                this.txtHoraFin.Value = turno.HORA_FIN;
                this.txtPrecioBase.Value = turno.PRECIO_BASE;
                this.txtValorKilometro.Value = turno.VALOR_KM;
                this.chkHabilitado.Checked = turno.HABILITADO;
            }

            this.id = id;
        }
        #endregion

        #region Common

        private void Inicializar()
        {
            InitializeComponent();
            LimpiaControles();
            this.btnAceptar.Click -= btnAceptar_Click;
            this.btnAceptar.Click -= btnModificar_Click;
        }

        private void LimpiaControles()
        {
            this.txtDescripcion.Text = String.Empty;
            this.txtHoraFin.Value = 0;
            this.txtHoraInicio.Value = 0;
            this.txtPrecioBase.Value = 0;
            this.txtValorKilometro.Value = 0;

            LimpiaErrores(this.txtDescripcion);
            LimpiaErrores(this.txtHoraFin);
            LimpiaErrores(this.txtHoraInicio);
            LimpiaErrores(this.txtPrecioBase);
            LimpiaErrores(this.txtValorKilometro);
            LimpiaErrores(this.chkHabilitado);
        }

        private void LimpiaErrores(Control c)
        {
            this.errorProvider1.SetError(c, String.Empty);
        }

        private bool ValidaInfo()
        {
            bool descValida = ValidaRequerido(this.txtDescripcion);
            bool horaInicioValida = ValidaRequerido(this.txtHoraFin);
            bool horaFinValida = ValidaRequerido(this.txtHoraFin);
            bool precioBaseValido = ValidaRequerido(this.txtPrecioBase); 
            bool valorKmValido = ValidaRequerido(this.txtValorKilometro);

            return descValida && horaFinValida && horaInicioValida && precioBaseValido && valorKmValido;
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

            try
            {
                this.Modificacion(this.txtDescripcion.Text, this.txtHoraInicio.Value, this.txtHoraFin.Value,
                    this.txtPrecioBase.Value, this.txtValorKilometro.Value, this.chkHabilitado.Checked, this.id);
                this.lblError.Text = "La modificacion de turno ha sido exitosa";
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

        private void Modificacion(string desc, decimal horaInicio, decimal horaFin, decimal precioBase, decimal valorKm, bool habilitado, int id)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var turnoExistente = dbCtx.TURNOS.First(t => t.ID_TURNO == id);

                turnoExistente.DESCRIPCION = desc;
                turnoExistente.HORA_INICIO = horaInicio;
                turnoExistente.HORA_FIN = horaFin;
                turnoExistente.PRECIO_BASE = precioBase;
                turnoExistente.VALOR_KM = valorKm;
                turnoExistente.HABILITADO = habilitado;

                ValidacionesTurno(horaInicio, horaFin, turnoExistente, dbCtx);

                dbCtx.SaveChanges();
            }
        }
        #endregion

    }

    public class TurnoGridData
    {
        public int id { get; set; }
        public decimal horaInicio { get; set; }
        public decimal horaFin { get; set; }

        public string descripcion { get; set; }

        public decimal precioBase { get; set; }

        public decimal valorKilometro { get; set; }
        public bool habilitado { get; set; }
    }
}
