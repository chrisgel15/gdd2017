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
    public partial class Alta : Form
    {
        private bool habilitaDatos = false;
        private bool impactado = false;
        private int id_chofer;
                
        public Alta()
        {
            InitializeComponent();
            inicializaCombo();
        }

       

        private void inicializaCombo() 
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var marcas = dbCtx.MARCAS.ToList();
                comboMarca.DataSource = marcas;
                comboMarca.DisplayMember = "NOMBRE";
                comboMarca.ValueMember = "NOMBRE";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcepAlta_Click(object sender, EventArgs e)
        {
            var nombre = txtNomChofer.Text;
            var apellido = txtApeChofer.Text;
            var modelo = txtModelo.Text;
            var patente = txtPatente.Text;
            var licencia = txtLicencia.Text;
            var rodado = txtRodado.Text;
            var turno = txtTurno.Text;

            AUTO auto = new AUTO
            {
                MODELO = modelo,
                PATENTE = patente,
                LICENCIA = licencia,
                RODADO = rodado,
                HABILITADO = true,
                
            };
            
            dvmAlta();

            if (habilitaDatos)
            {
                impactarDatos(auto);
                limpiarCampo();
                
            }
            if (impactado) 
            {
                MessageBox.Show("Se guardaron los datos");
                this.Close();
            }
        }

        private void limpiarCampo()
        {
            txtModelo.Text = String.Empty;
            txtPatente.Text = String.Empty;
            txtTurno.Text = String.Empty;
            txtNomChofer.Text = String.Empty;
            txtApeChofer.Text = String.Empty;
            txtLicencia.Text = String.Empty;
            txtRodado.Text = String.Empty;
        }

        private void impactarDatos(AUTO auto)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                /*Guardo el id de la marca*/
                var marca = dbCtx.MARCAS.Where(m => m.NOMBRE == comboMarca.Text).FirstOrDefault();
                auto.MARCA_ID = marca.ID_MARCA;
                
                /*guardo el id del chofer traido en dvmDatosBase*/
                auto.CHOFER_ID = id_chofer;

                /*Busco el turno para crear registro en tabla relacion AUTOS_TURNOS*/
                string substrTurno = txtTurno.Text.Substring(0,3); //pido ingresar en el form "mañana", "tarde" o "noche", guardo las primeras letras
                
                var turno = dbCtx.TURNOS.Where(t => t.DESCRIPCION.
                    Contains(substrTurno)).FirstOrDefault();

                //Agrago un auto a la lista de autos que tiene el turno
                turno.AUTOS.Add(auto);
                //agrego el auto a la base
                dbCtx.AUTOS.Add(auto);
                
                dbCtx.SaveChanges();
                
            }

            impactado = true;
            
        }

        #region ValidacionDatos
        private void dvmAlta()
        {
            habilitaDatos = false;
            //Valida que los campos no estén vacios para poder continuar
            dvmCamposVacios();
            //Valida el formato de los datos ingresados en el form
            dvmFormatoDatos();
            //Valida la existencia de los datos en la base
            dvmDatosEnBase();
         }

        private void dvmFormatoDatos()
        {
            /*Mejorar implementacion -> no dice nada al usuario de cual es el campo que no cumple
            condicion.*/

            if (txtRodado.Text.Length > 10 || txtPatente.Text.Length > 10 || txtLicencia.Text.Length > 26)
            {
                MessageBox.Show("La cantidad de caracteres excede el máximo");
                habilitaDatos = false;
                return;
            }
            else
                habilitaDatos = true;
        }

        private void dvmDatosEnBase()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                //Verifica si la patente ingresada en el form ya existe
                if (dbCtx.AUTOS.Any(a => a.PATENTE == this.txtPatente.Text))
                {
                    MessageBox.Show("Ya existe esa patente en el sistema");
                    txtPatente.Text = String.Empty;
                    return;
                }
                
            }
            
            using(var dbCtx = new GD1C2017Entities())
            {
                
                var chofer = dbCtx.CHOFERES.Where(c => c.APELLIDO == txtApeChofer.Text && c.NOMBRE == txtNomChofer.Text).FirstOrDefault();
                if (chofer == null)
                {
                    MessageBox.Show("No existe el chofer");
                    habilitaDatos = false;
                    return;
                }
                else
                {
                    id_chofer = chofer.ID_CHOFER;
                    var auto = dbCtx.AUTOS.Where(a => a.CHOFER_ID == id_chofer).FirstOrDefault();
                    if (auto.HABILITADO)
                    {
                        MessageBox.Show("El chofer ya tiene asignado un auto activo\n" + "seleccione un chofer diferente");
                        txtNomChofer.Text = String.Empty;
                        txtApeChofer.Text = String.Empty;
                        habilitaDatos = false;
                        return;
                    }
                    habilitaDatos = true;
                }

                
            }
            
           
          }
        

        private void dvmCamposVacios()
        {
            List<String> mensajes = new List<string>();
            StringBuilder mensajeValidacion = new StringBuilder("");

            if (String.IsNullOrEmpty(txtModelo.Text))
                mensajes.Add(lblModelo.Text);

            if (String.IsNullOrEmpty(txtPatente.Text))
                mensajes.Add(lblPatente.Text);

            if (String.IsNullOrEmpty(txtTurno.Text))
                mensajes.Add(lblTurno.Text);

            if (String.IsNullOrEmpty(txtNomChofer.Text))
                mensajes.Add(lblNomChofer.Text);

            if (String.IsNullOrEmpty(txtApeChofer.Text))
                mensajes.Add(lblApeChofer.Text);

            if (mensajes.Count > 0)
            {
                foreach (var m in mensajes)
                {
                    mensajeValidacion.Append("El campo " + m + " es requerido\n");
                }
                MessageBox.Show(mensajeValidacion.ToString());
                habilitaDatos = false;
                mensajes.Clear();
            }
            else
                habilitaDatos = true;
        }
        #endregion ValidacionDAtos


        #region OtrosEventos

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTurno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtChofer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMarca_DropDown(object sender, EventArgs e)
        {

        }
        #endregion OtrosEventos
    }
}
