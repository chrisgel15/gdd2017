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
    public partial class ModificaNombre : Form
    {
        private int idRol;

        public ModificaNombre()
        {
            InitializeComponent();
        }

        public ModificaNombre(int r)
        {
            InitializeComponent();
            this.idRol = r;
            CargaNombre();
            this.label1.Text = String.Empty;
        }

        private void CargaNombre()
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var nom = dbCtx.ROLES.Where(r => r.ID_ROL == this.idRol).FirstOrDefault();

                this.textBox1.Text = nom.NOMBRE;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = String.Empty;
            var nuevoNombre = this.textBox1.Text;

            if (String.IsNullOrEmpty(nuevoNombre))
            {
                this.label1.Text = "El nombre no puede ser vacio";
                return;
            }

            using (var dbCtx = new GD1C2017Entities())
            {

                var rol = dbCtx.ROLES.Where(r => r.ID_ROL == this.idRol).FirstOrDefault();

                if (!dbCtx.ROLES.Any(r => r.NOMBRE == nuevoNombre && r.ID_ROL != this.idRol))
                {
                    rol.NOMBRE = nuevoNombre;
                    this.label1.Text = "El nombre del rol fue modificado correctamente.";
                }
                else
                {
                    this.label1.Text = "Ya existe un rol con ese nombre";
                }

                dbCtx.SaveChanges();

            }


        }

    }


}

