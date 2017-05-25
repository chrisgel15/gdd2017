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
    public partial class FormChoferCliente : Form
    {

        #region Propiedades

        public IChoferCliente choferCliente { get; set; }

        public string busqueda { get; set; }

        #endregion

        #region Constructores
        public FormChoferCliente(IChoferCliente clients)
        {
            InitializeComponent();
            this.choferCliente = clients;
            this.lblTipo.Text = this.choferCliente.Tipo;
            this.CrearDataGrid();
            this.dataGridView1.Visible = false;
            this.lblMsgChoferCliente.Text = String.Empty;
        }
        #endregion        

        #region Busqueda y modificacion
        public void CrearDataGrid()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn()
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "id"
            };

            DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn()
            {
                Name = "NOMBRE",
                HeaderText = "NOMBRE",
                DataPropertyName = "nombre"
            };

            DataGridViewTextBoxColumn apellido = new DataGridViewTextBoxColumn()
            {
                Name = "APELLIDO",
                HeaderText = "APELLIDO",
                DataPropertyName = "apellido"

            };

            DataGridViewTextBoxColumn dni = new DataGridViewTextBoxColumn()
            {
                Name = "DNI",
                HeaderText = "DNI",
                DataPropertyName = "dni"
            };

            DataGridViewCheckBoxColumn habilitado = new DataGridViewCheckBoxColumn()
            {
                Name = "HABILITADO",
                HeaderText = "HABILITADO",
                DataPropertyName = "habilitado"
            };

            var columnaActualizar = new DataGridViewButtonColumn();
            columnaActualizar.Name = "Actualizar";
            columnaActualizar.Text = "Actualizar";
            columnaActualizar.UseColumnTextForButtonValue = true;


            var columnaHabilitar = new DataGridViewButtonColumn();
            columnaHabilitar.Name = "Habilitar";
            columnaHabilitar.Text = "Habilitar";
            columnaHabilitar.UseColumnTextForButtonValue = true;


            var columnaDeshabilitar = new DataGridViewButtonColumn();
            columnaDeshabilitar.Name = "Deshabilitar";
            columnaDeshabilitar.Text = "Deshabilitar";
            columnaDeshabilitar.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Insert(0, id);
            dataGridView1.Columns.Insert(1, nombre);
            dataGridView1.Columns.Insert(2, apellido);
            dataGridView1.Columns.Insert(3, dni);
            dataGridView1.Columns.Insert(4, habilitado);
            dataGridView1.Columns.Insert(5, columnaActualizar);
      
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            dataGridView1.DataSource = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lblMsgChoferCliente.Text = String.Empty;
            this.busqueda = this.txtBusqueda.Text;

            this.dataGridView1.DataSource = this.choferCliente.Buscar(busqueda);
            this.dataGridView1.Visible = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblMsgChoferCliente.Text = String.Empty;
            var item = (GridData)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == dataGridView1.Columns["Actualizar"].Index)
            {
                try
                {
                    this.choferCliente.AbrirFormActualizar(item.id);
                    this.RefrescarGrilla();
                    
                }
                catch(Exception ex)
                {
                    // Mostrar error
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["Habilitado"].Index)
            {               
                try
                {
                    this.choferCliente.Habilitar(item.id);
                }
                catch(Exception ex)
                {
                    this.lblMsgChoferCliente.Text = "Ha ocurrido un error con la Habilitacion/Inhabilitacion del " + this.lblTipo.Text;
                }
            }       

        }

        private void RefrescarGrilla()
        {
            this.dataGridView1.DataSource = this.choferCliente.Buscar(busqueda);
        }
        #endregion

        #region Alta
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lblMsgChoferCliente.Text = String.Empty;
            this.dataGridView1.Visible = false;
            this.choferCliente.AbrirForm();
        }
        #endregion
    }
}
