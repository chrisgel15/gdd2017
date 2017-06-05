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
        private String trimestre_combo;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void boxOpciones_Click(object sender, EventArgs e)
        {
            /*using (var dbCtx = new GD1C2017Entities())
            {
                using (System.Data.SqlClient.SqlCommand cmd = new SqlCommand("choferesMayorRecaudacionSP",dbCtx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Anio", SqlDbType.VarChar).Value = aniotxtb.Text;
                    var trimestre = comboBoxTRIMESTRE.SelectedItem.ToString();
                    switch (trimestre)
                    {
                        case "1":
                            cmd.Parameters.Add("@Inicio", SqlDbType.VarChar).Value = 1;
                            cmd.Parameters.Add("@Fin", SqlDbType.VarChar).Value = 3;
                        case "2":
                            cmd.Parameters.Add("@Inicio", SqlDbType.VarChar).Value = 4;
                            cmd.Parameters.Add("@Fin", SqlDbType.VarChar).Value = 6;
                        case "3":
                            cmd.Parameters.Add("@Inicio", SqlDbType.VarChar).Value = 7;
                            cmd.Parameters.Add("@Fin", SqlDbType.VarChar).Value = 9;
                        case "4":
                            cmd.Parameters.Add("@Inicio", SqlDbType.VarChar).Value = 10;
                            cmd.Parameters.Add("@Fin", SqlDbType.VarChar).Value = 12;
                    }
                    
                    cmd.ExecuteNonQuery();
                }*/
            }
       
    }
}

