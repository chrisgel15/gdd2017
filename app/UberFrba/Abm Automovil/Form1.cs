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

        private void button1_Click(object sender, EventArgs e)
        {
            this.form1.Close();
        }
    }
}
