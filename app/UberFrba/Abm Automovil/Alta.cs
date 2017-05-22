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
        public Alta()
        {
            InitializeComponent();
            inicializaCombo();
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

        private void inicializaCombo() 
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var marcas = dbCtx.MARCAS.GroupBy(m => m.NOMBRE).ToList();
                foreach (var marca in marcas)
                {
                    comboMarca.Items.Add(marca.ToString());
                }

            }
        }
    }
}
