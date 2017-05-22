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
    public partial class ModificaFuncionalidades : Form
    {
        private int idRol;

        public ModificaFuncionalidades()
        {
            InitializeComponent();
        }

        public ModificaFuncionalidades(int r)
        {
            InitializeComponent();
            this.idRol = r;
            CargaFuncionalidades();
            this.label1.Text = String.Empty;
        }

        private void CargaFuncionalidades()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var func = dbCtx.ROLES.Where(r => r.ID_ROL == this.idRol).FirstOrDefault().FUNCIONALIDADES.ToList();

                ((ListBox)this.checkedListBox1).DataSource = dbCtx.FUNCIONALIDADES.ToList();
                ((ListBox)this.checkedListBox1).DisplayMember = "NOMBRE";
                ((ListBox)this.checkedListBox1).ValueMember = "ID_FUNC";

                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                {
                    FUNCIONALIDADE f = (FUNCIONALIDADE)this.checkedListBox1.Items[i];

                    if (func.Contains(f))
                        this.checkedListBox1.SetItemChecked(i, true);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dbCtx = new GD1C2017Entities())
            {

                ROLE rol = dbCtx.ROLES.Where(r => r.ID_ROL == this.idRol).FirstOrDefault();

                rol.FUNCIONALIDADES.Clear();

                dbCtx.SaveChanges();

                rol.FUNCIONALIDADES = new List<FUNCIONALIDADE>();

                foreach (object o in this.checkedListBox1.CheckedItems)
                {
                    FUNCIONALIDADE f = (FUNCIONALIDADE)o;
                    rol.FUNCIONALIDADES.Add(f);
                    rol.FUNCIONALIDADES.Add(dbCtx.FUNCIONALIDADES.Where(fun => fun.ID_FUNC == f.ID_FUNC).FirstOrDefault());
                }

                dbCtx.SaveChanges();
            }

            this.label1.Text = "Las funcionalidades fueron modificadas correctamente.";


        }

    }


}

