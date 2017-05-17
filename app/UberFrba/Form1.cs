using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.SetErrorMessage("", System.Drawing.Color.Red);

            using (var dbCtx = new GD1C2017Entities())
            {
                var usu = dbCtx.USUARIOS.Where(u => u.NOMBRE == this.txtUsuario.Text).FirstOrDefault();

                if (usu == null)
                    this.SetErrorMessage("El usuario no existe", System.Drawing.Color.Black);
                else
                {
                    if (!usu.PASSWORD.SequenceEqual(SHA256Encrypt(this.txtPassword.Text)))
                    {
                        this.AgregaCantidadFallas(usu);
                        this.InhabilitaUsuario(usu);
                    }
                    else
                        this.IngresoDeUsuario(usu);                  
                }
                dbCtx.SaveChanges();
            }
        }

        private void IngresoDeUsuario(USUARIO usu)
        {
            if (usu.HABILITADO)
                this.SetErrorMessage("Bienvenido!", System.Drawing.Color.Blue);
            else
                this.SetErrorMessage("Usuario Inhabilitado.", System.Drawing.Color.Red);
        }

        private void InhabilitaUsuario(USUARIO usu)
        {
            if (!usu.HABILITADO)
            {
                this.SetErrorMessage("Usuario Inhabilitado", System.Drawing.Color.Red);
            }
            else if (usu.CANT_FALLAS >= 3)
            {
                usu.HABILITADO = false;
                this.SetErrorMessage("Contraseña incorrecta. Usuario Inhabilitado.", System.Drawing.Color.Red);
            }
            else
            {
                this.SetErrorMessage("Contraseña incorrecta", System.Drawing.Color.DarkRed);
            }
        }

        private void AgregaCantidadFallas(USUARIO usu)
        {
            usu.CANT_FALLAS++;
        }

        public byte[] SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            return hashedBytes;
        }

        private void SetErrorMessage(string msg, System.Drawing.Color color)
        {
            this.lblError.Text = msg;
            this.lblError.ForeColor = color;
        }

    }
}
