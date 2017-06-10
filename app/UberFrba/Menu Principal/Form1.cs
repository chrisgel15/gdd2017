using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Menu_Principal
{
    public partial class Form1 : Form
    {
        private Estado Estado;
        public List<ROLE> roles { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Estado est)
        {
            this.Estado = est;
            InitializeComponent();
            SetearLabels();
            //  ActivarBotonesSegunRol(this.roles);
        }

        private void ActivarBotonesSegunRol(List<FUNCIONALIDADE> funcionalidades)
        {
            this.btnAbmRol.Enabled = false;
            this.btnABMCliente.Enabled = false;
            this.btnAbmAuto.Enabled = false;
            this.btnABMChofer.Enabled = false;
            this.btnRegistroViaje.Enabled = false;
            this.btnRendicion.Enabled = false;
            this.btnFacturacion.Enabled = false;
            this.btnReportes.Enabled = false;
            this.btnAbmTurno.Enabled = false;


            foreach (FUNCIONALIDADE f in funcionalidades)
            {
                switch (f.ID_FUNC)
                {
                    case 1: this.btnAbmRol.Enabled = true; break;
                    //case 2: 
                    //case 3: 
                    case 4: this.btnABMCliente.Enabled = true; break;
                    case 5: this.btnAbmAuto.Enabled = true; break;
                    case 6: this.btnABMChofer.Enabled = true; break;
                    case 7: this.btnRegistroViaje.Enabled = true; break;
                    case 8: this.btnRendicion.Enabled = true; break;
                    case 9: this.btnFacturacion.Enabled = true; break;
                    case 10: this.btnReportes.Enabled = true; break;
                    case 11: this.btnAbmTurno.Enabled = true; break;
                    default: break;
                }
            }



        }

        private void SetearLabels()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var usu = dbCtx.USUARIOS.Where(u => u.ID_USUARIO == Estado.IdUsuario && u.HABILITADO).FirstOrDefault();

                this.lblNombreUsuario.Text = usu.NOMBRE;
                this.lblRolUsuario.Text = dbCtx.ROLES.Where(r => r.ID_ROL == Estado.IdRol).FirstOrDefault().NOMBRE;
                // this.roles = usu.ROLES.ToList();

                var funcionalidades = dbCtx.ROLES.Where(r => r.ID_ROL == this.Estado.IdRol).First().FUNCIONALIDADES.ToList();
                ActivarBotonesSegunRol(funcionalidades);


            }
        }

        private void ActivarBotonesSegunRol()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbmRol_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_Rol.ABMRol(this.Estado).ShowDialog();
        }

        private void btnABMChofer_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_ChoferCliente.FormChoferCliente(new Chofer()).Show();
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_ChoferCliente.FormChoferCliente(new Clients()).Show();
        }


        private void btnAbmAuto_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_Automovil.Form1().Show();
        }

        private void btnAbmTurno_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_Turno.AbmTurno().Show();

        }

        private void btnRegistroViaje_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Registro_Viajes.Form1().Show();
        }

        private void btnRendicion_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Rendicion_Viajes.Form1().Show();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Facturacion.Form1().Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Listado_Estadistico.Form1().Show();
        }





    }
}
