using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class Listado : Form
    {
        private string marca_combo;
        private Modificacion modifForm;
        public Listado()
        {
            InitializeComponent();
            List<String> filtrosDisponibles = new List<string> { "Marca", "Modelo", "Patente", "Chofer" };
            initCombo(filtrosDisponibles);
                        
        }

        private void initCombo(List<string> filtrosDisponibles)
        {
            foreach(var f in filtrosDisponibles)
            {
                comboFiltros.Items.Add(f);
            }
        }

        private void comboFiltros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var filtro = comboFiltros.SelectedItem.ToString();
            switch (filtro) 
            {
                case "Marca":
                    lblMarca.Visible = true;
                    comboMarca.Visible = true;
                    initMarca();
                    
                    break;
                case "Modelo":
                    lblModelo.Visible = true;
                    txtModelo.Visible = true;
                    
                    break;
                case "Patente":
                    lblPatente.Visible = true;
                    txtPatente.Visible = true;
                    
                    break;
                case "Chofer":
                    lblChofer.Visible = true;
                    txtChofer.Visible = true;
                    
                    break;
                default:
                    break;
            }
        }

        private void initMarca()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var marcas = dbCtx.MARCAS.ToList();
                comboMarca.DataSource = marcas;
                comboMarca.DisplayMember = "NOMBRE";
                comboMarca.ValueMember = "NOMBRE";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChofer.Text = String.Empty;
            txtChofer.Visible = false;
            lblChofer.Visible = false;

            txtModelo.Text = String.Empty;
            txtModelo.Visible = false;
            lblModelo.Visible = false;

            txtPatente.Text = String.Empty;
            txtPatente.Visible = false;
            lblPatente.Visible = false;

            comboMarca.Visible = false;
            lblMarca.Visible = false;

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var _modelo = txtModelo.Text;
            var _patente = txtPatente.Text;
            var _chofer = txtChofer.Text;
            var _marca = marca_combo;

            gridResultados.Visible = true;
            Brand.DataPropertyName = "marca";
            Modelo.DataPropertyName = "modelo";
            Patente.DataPropertyName = "patente";
            Licencia.DataPropertyName = "licencia";
            Rodado.DataPropertyName = "rodado";
            Chofer.DataPropertyName = "chofer";

            Seleccionar.UseColumnTextForButtonValue = true;
            Deshabilitar.UseColumnTextForButtonValue = true;

            List<AUTO> q1 = new List<AUTO>();
            using (var dbCtx = new GD1C2017Entities())
            {

                q1 = dbCtx.AUTOS.ToList();
                q1 = dbCtx.AUTOS.Where(a => a.MARCA.NOMBRE == _marca).ToList();
                q1 = q1.Where(a => a.MODELO.Contains(_modelo.ToUpper())).ToList();
                q1 = q1.Where(a => a.PATENTE.Contains(_patente)).ToList();
                q1 = q1.Where(a => a.CHOFERE.NOMBRE.Contains(_chofer) ||
                    a.CHOFERE.APELLIDO.Contains(_chofer)).ToList();
                
                var q2 = q1.Select( o => 
                    new GridQueryResult
                    {
                        patente = o.PATENTE,
                        licencia = o.LICENCIA,
                        modelo = o.MODELO,
                        rodado = o.RODADO,
                        marca = o.MARCA.NOMBRE,
                        chofer = o.CHOFERE.NOMBRE + " " + o.CHOFERE.APELLIDO,
                        habilitado = o.HABILITADO,
                        id = o.ID_AUTO
                    }).ToList();

                gridResultados.AutoGenerateColumns = false;
                gridResultados.DataSource = q2;
                
                
                
           }
        }

        private void comboMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            marca_combo = comboMarca.SelectedValue.ToString();
        }

        private void gridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grilla = (DataGridView)sender;
            var item = (GridQueryResult)this.gridResultados.Rows[e.RowIndex].DataBoundItem;
            
            if (e.ColumnIndex == grilla.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                modifForm = new Abm_Automovil.Modificacion(item);
                modifForm.Show();

            }
            
            if (e.ColumnIndex == grilla.Columns["Deshabilitar"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Esta Seguro?", "Deshabilitar Auto",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                if (result == DialogResult.Yes)
                {
                    deshabilitarItem(item);
                }

            }
        }

        private void deshabilitarItem(GridQueryResult item)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var auto = dbCtx.AUTOS.Where(
                    a => a.MARCA.NOMBRE == item.marca &&
                        a.MODELO == item.modelo &&
                        a.LICENCIA == item.licencia &&
                        a.PATENTE == item.patente &&
                        a.RODADO == item.rodado && (
                        a.CHOFERE.NOMBRE == item.chofer || a.CHOFERE.APELLIDO == item.chofer)).
                        First();
                if (auto.HABILITADO)
                    auto.HABILITADO = !auto.HABILITADO;
                
                dbCtx.SaveChanges();

                
            }
        }

    }
}


public class GridQueryResult 
{
    public string marca { get; set; }
    public string modelo { get; set; }
    public string licencia { get; set; }
    public string patente {get; set;}
    public string rodado {get; set;}
    public string chofer { get; set; }
    public bool habilitado { get; set; }
    public int id { get; set; }

}