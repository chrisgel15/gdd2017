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
    public partial class Modificacion : Form
    {
        private GridQueryResult item;
        private AutoDatosModificado modifAuto;
        private bool actualiza;
       
        public Modificacion()
        {
            InitializeComponent();
            
        }

        public Modificacion(GridQueryResult item)
        {
            // TODO: Complete member initialization
            this.item = item;
            InitializeComponent();
            this.modifAuto = new AutoDatosModificado();
            cargaControles();
            
        }
        private void cargaControles()
        {
            txtChofer.Text = item.chofer;
            txtLicencia.Text = item.licencia;
            txtModelo.Text = item.modelo;
            txtPatente.Text = item.patente;
            txtRodado.Text = item.rodado;
            chkHabilitado.Checked = item.habilitado;

            using (var dbCtx = new GD1C2017Entities()) 
            {
                var auto = dbCtx.AUTOS.Where(a => a.PATENTE == txtPatente.Text).FirstOrDefault();
                var turnos = auto.TURNOS.ToList();
                var turnosDisponibles = dbCtx.TURNOS.ToList();
                ((ListBox)checkedListBoxTurnos).DataSource = turnosDisponibles;
                ((ListBox)checkedListBoxTurnos).ValueMember = "ID_TURNO";
                ((ListBox)checkedListBoxTurnos).DisplayMember = "DESCRIPCION";

                foreach (var _turno in turnos) 
                {
                    if (turnosDisponibles.Contains(_turno))
                        checkedListBoxTurnos.SetItemChecked(checkedListBoxTurnos.Items.IndexOf(_turno), true);
                }
             }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*Guardo en variables auxiliares los valores modificados 
             *con los que se va a actualizar el registro
             */
            modifAuto._modelo = txtModelo.Text;
            modifAuto._patente = txtPatente.Text;
            modifAuto._licencia = txtLicencia.Text;
            modifAuto._rodado = txtRodado.Text;
            modifAuto._chofer = txtChofer.Text;
            //------------------------------------------------------//

            /*Valida regla de negocio de unico auto activo asignado*/
            actualiza = dvm(modifAuto);
            
            
            using (var dbCtx = new GD1C2017Entities())
            {
                /*Traigo de la base el registro a modificar
                * mediante el "id" que lo tengo en la referencia "item" 
                */
                var auto = dbCtx.AUTOS.Where(a => a.ID_AUTO == item.id).FirstOrDefault();
                
                if (actualiza)
                {
                    /*Borro la lista de turnos del auto para luego agregarle las
                    seleccionadas en checkedListbox*/
                    auto.TURNOS.Clear();
                    dbCtx.SaveChanges();
                    auto.TURNOS = new List<TURNO>();
                    foreach (var t in checkedListBoxTurnos.CheckedItems)
                    {
                        TURNO _turn = (TURNO)t;
                        auto.TURNOS.Add(dbCtx.TURNOS.Where(tu => tu.ID_TURNO == _turn.ID_TURNO).FirstOrDefault());
                    }
                    auto.MODELO = modifAuto._modelo;
                    auto.PATENTE = modifAuto._patente;
                    auto.LICENCIA = modifAuto._licencia;
                    auto.RODADO = modifAuto._rodado;
                    auto.HABILITADO = modifAuto._habilitado;
                    auto.CHOFER_ID = modifAuto._choferId;
                                       
                    dbCtx.SaveChanges();

                    MessageBox.Show("Se guardó la modificación");
                }
            }
         }

        private bool dvm(AutoDatosModificado modifAuto)
        {
            //Separo en nombre y apellido
            string[] nombreApellido;
            nombreApellido = modifAuto._chofer.Split(' ');


            using (var dbCtx = new GD1C2017Entities()) 
            {
                var _nombre = nombreApellido[0];
                var _apellido = nombreApellido[1];
                /*Busco el chofer por nombre y apellido*/
                var chofer = dbCtx.CHOFERES.
                    Where(c => c.NOMBRE.Contains(_nombre.ToUpper()) && c.APELLIDO.Contains(_apellido)).
                    FirstOrDefault();

                /*Si no lo encuentra*/
                if (chofer == null)
                {
                    MessageBox.Show("El chofer que desea no existe");
                    return false;
                }
                
                /*Si le quiere asignar auto activo y ya tiene otro previamente*/
                
                if (chofer.AUTOS.Any(a => a.HABILITADO && a.PATENTE != modifAuto._patente) && modifAuto._habilitado)
                {
                    MessageBox.Show("El chofer ya tiene asignado un auto en estado Activo.\n" +
                     "Debe ingresar otro chofer ó asignarle el auto con estado No Activo");
                    txtChofer.Text = String.Empty;
                    return false;
                }
                
                /*Guardo el id del chofer para actualizarselo al auto*/
                else
                    modifAuto._choferId = chofer.ID_CHOFER;
                return true;
            }
        }

       

        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            modifAuto._habilitado = chkHabilitado.Checked;
        }

        private void txtChofer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdTurno_Click(object sender, EventArgs e)
        {
            
        }
    }

   
}


 class AutoDatosModificado
    {
        public string _modelo {get; set;} 
        public string _patente {get; set;} 
        public string _licencia {get; set;} 
        public string _rodado {get; set;}
        public string _chofer { get; set;}
        public bool _habilitado { get; set;}
        public int _choferId { get; set; }
    }