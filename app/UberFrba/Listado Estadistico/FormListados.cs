using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Listado_Estadistico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 4; i++)
            {
                comboBoxTRIMESTRE.Items.Add(i);
            }

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                String trimestre = comboBoxTRIMESTRE.SelectedItem.ToString();
                String inicio = "";
                String fin = "";

                using (var dbCtx = new GD1C2017Entities())
                {


                    switch (trimestre)
                    {
                        case "1":
                            inicio = "01";
                            fin = "03";
                            break;
                        case "2":
                            inicio = "04";
                            fin = "06";
                            break;
                        case "3":
                            inicio = "07";
                            fin = "09";
                            break;
                        case "4":
                            inicio = "10";
                            fin = "12";
                            break;
                        default:
                            break;
                    }

                    SqlParameter inicioP = new SqlParameter("@Inicio", inicio);
                    SqlParameter finP = new SqlParameter("@Fin", fin);
                    List<GD1C2017Entities> lista = dbCtx.Database.SqlQuery<GD1C2017Entities>("exec ChoferesMayorRecaudacionSP @Inicio,@Fin", inicioP, finP).ToList();

                    gridResultados.DataSource = lista;


                }


            }
        }
    }
}