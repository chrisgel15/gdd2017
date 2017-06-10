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
            this.ChofViajeMasLargoBTT.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged_1);
            this.ChofMayorRecaudacionBTT.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged_1);
            this.ClienteMasVecesAutoBTT.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged_1);
            this.ClientesMayorConsumoBTT.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged_1);
        }



        private void RadioButtons_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBoxTRIMESTRE.DropDownStyle = ComboBoxStyle.DropDownList;
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
                String anioString = aniotxtb.Text;
                int anio = Int32.Parse(anioString);
                int inicioP = Int32.Parse(inicio);
                int finP = Int32.Parse(fin);
                try
                {
                  if(this.ChofMayorRecaudacionBTT.Checked)
                    gridResultados.DataSource = dbCtx.choferesMayorRecaudacionSP(anio, inicioP, finP);
                  if (this.ChofViajeMasLargoBTT.Checked)
                      gridResultados.DataSource = dbCtx.choferesViajeMasLargoSP(anio, inicioP, finP);
                  if (this.ClientesMayorConsumoBTT.Checked)
                      gridResultados.DataSource = dbCtx.clientesMayorConsumoSP(anio, inicioP, finP);
                  if (this.ClienteMasVecesAutoBTT.Checked)
                      gridResultados.DataSource = dbCtx.clientesMismoAutomovilMasFrecuenciaSP(anio, inicioP, finP);
                  
                }
                catch (Exception ex)
                {

                }
            }

        }
        

    }
}