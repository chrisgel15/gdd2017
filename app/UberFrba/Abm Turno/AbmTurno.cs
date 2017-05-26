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
    public partial class AbmTurno : Form
    {
        #region Propiedades

        public string busqueda { get; set; }

        #endregion

        #region Constructores
        public AbmTurno()
        {
            InitializeComponent();
            this.CrearDataGrid();
            this.dataGridTurno.Visible = false;
            this.lblMsgTurno.Text = String.Empty;
        }
        #endregion        

        #region Busqueda y modificacion
        public void CrearDataGrid()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn()
            {
                Name = "ID_TURNO",
                HeaderText = "ID_TURNO",
                DataPropertyName = "id"
            };

            DataGridViewTextBoxColumn descripcion = new DataGridViewTextBoxColumn()
            {
                Name = "DESCRIPCION",
                HeaderText = "DESCRIPCION",
                DataPropertyName = "descripcion"
            };

            DataGridViewTextBoxColumn horaInicio = new DataGridViewTextBoxColumn()
            {
                Name = "HORA_INICIO",
                HeaderText = "HORA_INICIO",
                DataPropertyName = "horaInicio"
            };

            DataGridViewTextBoxColumn horaFin = new DataGridViewTextBoxColumn()
            {
                Name = "HORA_FIN",
                HeaderText = "HORA_FIN",
                DataPropertyName = "horaFin"

            };

            DataGridViewTextBoxColumn precioBase = new DataGridViewTextBoxColumn()
            {
                Name = "PRECIO_BASE",
                HeaderText = "PRECIO_BASE",
                DataPropertyName = "precioBase"
            };

            DataGridViewTextBoxColumn valorKilometro = new DataGridViewTextBoxColumn()
            {
                Name = "VALOR_KM",
                HeaderText = "VALOR_KM",
                DataPropertyName = "valorKilometro"
            };

            DataGridViewTextBoxColumn habilitado = new DataGridViewTextBoxColumn()
            {
                Name = "HABILITADO",
                HeaderText = "HABILITADO",
                DataPropertyName = "habilitado"
            };

            var columnaActualizar = new DataGridViewButtonColumn();
            columnaActualizar.Name = "Actualizar";
            columnaActualizar.Text = "Actualizar";
            columnaActualizar.UseColumnTextForButtonValue = true;

            dataGridTurno.AutoGenerateColumns = false;
            dataGridTurno.Columns.Insert(0, id);
            dataGridTurno.Columns.Insert(1, descripcion);
            dataGridTurno.Columns.Insert(2, horaInicio);
            dataGridTurno.Columns.Insert(3, horaFin);
            dataGridTurno.Columns.Insert(4, precioBase);
            dataGridTurno.Columns.Insert(5, valorKilometro);
            dataGridTurno.Columns.Insert(6, habilitado);
            dataGridTurno.Columns.Insert(7, columnaActualizar);
      
            dataGridTurno.CellContentClick += dataGridView1_CellContentClick;

            dataGridTurno.DataSource = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lblMsgTurno.Text = String.Empty;
            this.busqueda = this.txtBusqueda.Text;

            this.dataGridTurno.DataSource = this.Buscar(busqueda);
            this.dataGridTurno.Visible = true;
            this.dataGridTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private IList<TurnoGridData> Buscar(string busqueda)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var turnos = dbCtx.TURNOS.Where(t => t.DESCRIPCION.Contains(busqueda)).Select(o =>
                    new TurnoGridData { id = o.ID_TURNO, descripcion = o.DESCRIPCION, horaInicio = o.HORA_INICIO, horaFin = o.HORA_FIN, 
                        habilitado = o.HABILITADO, precioBase = o.PRECIO_BASE, valorKilometro = o.VALOR_KM }).ToList();


                return turnos;

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblMsgTurno.Text = String.Empty;
            var item = (TurnoGridData)this.dataGridTurno.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == dataGridTurno.Columns["Actualizar"].Index)
            {
                try
                {
                    this.AbrirFormActualizar(item.id);
                    this.RefrescarGrilla();
                    
                }
                catch(Exception ex)
                {
                    // Mostrar error
                }
            }
        }

        private void AbrirFormActualizar(int id)
        {
            new Abm_Turno.AltaModificacion(id).ShowDialog();
        }

        private void RefrescarGrilla()
        {
            this.dataGridTurno.DataSource = this.Buscar(busqueda);
        }
        #endregion

        #region Alta
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lblMsgTurno.Text = String.Empty;
            this.dataGridTurno.Visible = false;
            this.AbrirForm();
        }

        private void AbrirForm()
        {
            new AltaModificacion().ShowDialog();
        }
        #endregion
    }
}
