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

namespace UberFrba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // ExecuteStoreProcedure();
        }
              public void ExecuteStoreProcedure()
        {
            //using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD1C2017;User ID=gd;Password=gestiondedatos2017!!"))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("insertTestTable", conn);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@nombre", "nombreBlaBla");
            //    cmd.ExecuteNonQuery();
            //}
        }
    }
}
