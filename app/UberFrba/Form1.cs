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
        Estado estado;
      

        public Form1()
        {
            InitializeComponent();
            InitializeErrorProviders();
            estado = new Estado();
            estado.Logueado = false;
            estado.IdUsuario = 0;
            estado.IdRol = 0;
        }

        private void InitializeErrorProviders()
        {
            errorProvider1.SetError(this.txtUsuario, String.Empty);
            errorProvider1.SetError(this.txtPassword, String.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ControlsValid())
                return;

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

                    estado.CantidadRoles = usu.ROLES.Count;

                    if (estado.CantidadRoles == 1)
                        estado.IdRol = usu.ROLES.FirstOrDefault().ID_ROL;
                }
                dbCtx.SaveChanges();

              

            }
            if (estado.Logueado)
            {

                if (estado.CantidadRoles == 0)
                    this.SetErrorMessage("El usuario no tiene roles asignados.", System.Drawing.Color.Orange);


                if (estado.CantidadRoles == 1)
                {
                    this.Hide();
                    new Menu_Principal.Form1(estado).Show();

                }

                if (estado.CantidadRoles > 1)
                {
                    this.Hide();
                    new Seleccion_Rol.Form1(estado).Show();
                }


            }

        }

        private void IngresoDeUsuario(USUARIO usu)
        {
            if (usu.HABILITADO)
            {
                this.SetErrorMessage("Bienvenido!", System.Drawing.Color.Blue);
                usu.CANT_FALLAS = 0;
                this.estado.Logueado = true;
                this.estado.IdUsuario = usu.ID_USUARIO;
            }
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

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
                errorProvider1.SetError(this.txtUsuario, "El usuario es requerido");
            else
                errorProvider1.SetError(this.txtUsuario, String.Empty);

            if (String.IsNullOrEmpty(txtPassword.Text))
                errorProvider1.SetError(this.txtPassword, "El password es requerido");
            else
                errorProvider1.SetError(this.txtPassword, String.Empty);

           

        }

        private bool ControlsValid()
        {
            return !String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtPassword.Text);
        }

    }

    public class Estado
    {
        #region Propiedades
        public bool Logueado { get; set; }

        public int IdUsuario { get; set; }

        public int IdRol { get; set; }

        public int CantidadRoles { get; set; }

        public Menu_Principal.Form1 Menu { get; set; }
        #endregion

    }
}


