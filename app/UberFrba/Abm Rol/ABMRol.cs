using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol
{
    public partial class ABMRol : Form
    {
        private Estado estado;

        public ABMRol()
        {
            InitializeComponent();
        }

        public ABMRol(Estado estado)
        {
            this.estado = estado;
            InitializeComponent();
            CargaFuncionalidadesYRoles(true, true);
        }

        private void CargaFuncionalidadesYRoles(bool funcionalidades, bool roles)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                if (funcionalidades)
                {
                var func = dbCtx.FUNCIONALIDADES.ToList();

                ((ListBox)this.checkedListBox1).DataSource = func;
                ((ListBox)this.checkedListBox1).DisplayMember = "NOMBRE";
                ((ListBox)this.checkedListBox1).ValueMember = "ID_FUNC";
                }

                if (roles) 
                {
                var rol = dbCtx.ROLES.ToList();

                this.modifRol.DataSource = rol;
                this.modifRol.DisplayMember = "NOMBRE";
                this.modifRol.ValueMember = "ID_ROL";
                }

            }

        }

        private void modifCambiarRol_Click(object sender, EventArgs e)
        {
            var frm = new Abm_Rol.ModificaNombre(int.Parse(modifRol.SelectedValue.ToString()));
            frm.ShowDialog();
            this.CargaFuncionalidadesYRoles(false, true);

        }


    }
}
