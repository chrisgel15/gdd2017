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

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Estado est)
        {
            this.Estado = est;
            InitializeComponent();
            SetearLabels();
        }

        private void DesactivarBotonesSegunRol(int idRol)
        {

        }

        private void SetearLabels()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var usu = dbCtx.USUARIOS.Where(u => u.ID_USUARIO == Estado.IdUsuario && u.HABILITADO).FirstOrDefault();

                this.lblNombreUsuario.Text = usu.NOMBRE;
                this.lblRolUsuario.Text = dbCtx.ROLES.Where(r => r.ID_ROL == Estado.IdRol).FirstOrDefault().NOMBRE;

            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_ChoferCliente.FormChoferCliente(new Chofer()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_ChoferCliente.FormChoferCliente(new Clients()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Estado.Menu = this;
            new Abm_Turno.AbmTurno().Show();
        }

        
       
    }
}
