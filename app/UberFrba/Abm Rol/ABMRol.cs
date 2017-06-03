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
            CargaFuncionalidadesYRoles(true, true, true);
            LimpiarLabels();
        }

        private void LimpiarLabels()
        {
            this.lblAlta.Text = String.Empty;
            this.lblModif.Text = String.Empty;
            this.lblBaja.Text = String.Empty;
        }

        private void CargaFuncionalidadesYRoles(bool funcionalidades, bool modifRoles, bool bajaRoles)
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

                if (modifRoles)
                {
                    var rol = dbCtx.ROLES.ToList();

                    this.modifRol.DataSource = rol;
                    this.modifRol.DisplayMember = "NOMBRE";
                    this.modifRol.ValueMember = "ID_ROL";
                }

                if (bajaRoles)
                {
                    var bRol = dbCtx.ROLES.ToList();

                    this.bajaRol.DataSource = bRol;
                    this.bajaRol.DisplayMember = "NOMBRE";
                    this.bajaRol.ValueMember = "ID_ROL";

                }

            }

        }

        private void modifCambiarRol_Click(object sender, EventArgs e)
        {
            this.LimpiarLabels();

            try
            {

                var frm = new Abm_Rol.ModificaNombre(int.Parse(modifRol.SelectedValue.ToString()));
                frm.ShowDialog();
                this.CargaFuncionalidadesYRoles(false, true, true);

            }
            catch (Exception ex)
            {
                this.lblModif.Text = "Ocurrio un error al modificar el nombre del rol.";
            }

        }

        private void modifHabRol_Click(object sender, EventArgs e)
        {
            this.LimpiarLabels();

            try
            {
                using (var dbCtx = new GD1C2017Entities())
                {
                    var idRol = int.Parse(modifRol.SelectedValue.ToString());
                    dbCtx.ROLES.Where(r => r.ID_ROL == idRol).FirstOrDefault().HABILITADO = true;
                    dbCtx.SaveChanges();
                }

                this.lblModif.Text = "El rol fue habilitado correctamente.";
            }
            catch (Exception ex)
            {
                this.lblModif.Text = "Ocurrio un error al habilitar el rol.";
            }
        }

        private void bajaDeshabRol_Click(object sender, EventArgs e)
        {
            this.LimpiarLabels();

            try
            {
                using (var dbCtx = new GD1C2017Entities())
                {
                    var idRol = int.Parse(bajaRol.SelectedValue.ToString());
                    dbCtx.ROLES.Where(r => r.ID_ROL == idRol).FirstOrDefault().HABILITADO = false;

                    // Quito el rol a todos los usuarios que lo tengan.
                    var rolParaQuitar = dbCtx.ROLES.Where(r => r.ID_ROL == idRol).FirstOrDefault();

                    var usuarios = dbCtx.USUARIOS.Where(
                        u => u.ROLES.Contains(dbCtx.ROLES.Where(r => r.ID_ROL == idRol).FirstOrDefault())
                        ).ToList();

                    foreach (USUARIO usu in usuarios)
                    {
                        usu.ROLES.Remove(rolParaQuitar);

                    }

                    dbCtx.SaveChanges();
                }

                this.lblBaja.Text = "El rol fue deshabilitado correctamente, y fue eliminado de los usuarios.";
            }
            catch (Exception ex)
            {
                this.lblBaja.Text = "Ocurrio un error al deshabilitar el Rol.";
            }
        }

        private void altaAceptar_Click(object sender, EventArgs e)
        {
            LimpiarLabels();

            if (String.IsNullOrEmpty(this.txtAltaRol.Text))
            {
                this.lblAlta.Text = "El nombre de rol es requerido";
                return;
            }

            if (this.checkedListBox1.CheckedItems.Count == 0)
            {
                this.lblAlta.Text = "Elija al menos una funcionalidad";
                return;
            }

            try
            {
                using (var dbCtx = new GD1C2017Entities())
                {
                    if (dbCtx.ROLES.Any(r => r.NOMBRE == this.txtAltaRol.Text))
                        this.lblAlta.Text = "El nombre de rol ya existe";
                    else
                    {
                        ROLE rol = new ROLE();
                        rol.NOMBRE = this.txtAltaRol.Text;
                        rol.HABILITADO = true;
                        rol.FUNCIONALIDADES = new List<FUNCIONALIDADE>();
                        foreach (object o in this.checkedListBox1.CheckedItems)
                        {
                            FUNCIONALIDADE f = (FUNCIONALIDADE)o;
                            rol.FUNCIONALIDADES.Add(dbCtx.FUNCIONALIDADES.Where(fun => fun.ID_FUNC == f.ID_FUNC).FirstOrDefault());
                        }

                        dbCtx.ROLES.Add(rol);

                        dbCtx.SaveChanges();
                        this.lblAlta.Text = "El rol fue agregado correctamente";

                    }

                    this.txtAltaRol.Text = String.Empty;
                    // TODO: Limpiar todos los tildes del checkedListBox.

                    CargaFuncionalidadesYRoles(false, true, true);
                }
            }
            catch (Exception ex)
            {
                this.lblAlta.Text = "Ocurrio un error en el alta de Rol.";
            }

            UncheckAll();
        }

        private void UncheckAll()
        {
            this.checkedListBox1.ClearSelected();
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void modifCambFunc_Click(object sender, EventArgs e)
        {
            this.LimpiarLabels();

            try
            {

                var frm = new Abm_Rol.ModificaFuncionalidades(int.Parse(modifRol.SelectedValue.ToString()));
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                this.lblModif.Text = "Ocurrio un error al modificar las funcionalidades del rol.";
            }

        }
    }


}

