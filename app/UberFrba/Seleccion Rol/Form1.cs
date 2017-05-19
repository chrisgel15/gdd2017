using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Seleccion_Rol
{
    public partial class Form1 : Form
    {
        private Estado estado;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Estado est)
        {
            this.estado = est;
            InitializeComponent();
            LlenarComboRoles();
        }

        private void LlenarComboRoles()
        {
            var idUsu = estado.IdUsuario;

            using (var dbCtx = new GD1C2017Entities())
            {
                var usu = dbCtx.USUARIOS.Where(u => u.ID_USUARIO == idUsu && u.HABILITADO).FirstOrDefault();

                this.btnElegirRol.DataSource = usu.ROLES.ToList();
                this.btnElegirRol.DisplayMember = "NOMBRE";
                this.btnElegirRol.ValueMember = "ID_ROL";

               
                dbCtx.SaveChanges();
            }
        }

        private void AceptarRol_Click(object sender, EventArgs e)
        {
            this.estado.IdRol = (int)this.btnElegirRol.SelectedValue;
            this.Hide();
            new Menu_Principal.Form1(this.estado).Show();

        }
    }
}
