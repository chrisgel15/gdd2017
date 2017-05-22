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
    public partial class Form1 : Form
    {
        private UberFrba.Form1 form1;
        private UberFrba.Abm_Automovil.Alta formAlta;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(UberFrba.Form1 form1)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.form1 = form1;
        }

        private void altaAuto_Click(object sender, EventArgs e)
        {
            formAlta = new Abm_Automovil.Alta();
            formAlta.Show();
        }

        
    }
}
