using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class Chofer : IChoferCliente
    {
        #region Propiedades
        public string Tipo { get { return "CHOFER";  } }

        public bool ValidarMail
        {
            get { return true; }
        }

        public bool ValidarCodigoPostal
        {
            get { return false; }
        }

        public bool HabilitarCodigoPostal { get { return false; } }
        #endregion

        #region Alta

        public string Alta(string nombre, string apellido, int dni, string mail, string direccion, int codPostal, DateTime fechaNac, int telefono)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                CHOFERE cho = new CHOFERE()
                {
                    NOMBRE = nombre,
                    APELLIDO = apellido,
                    DNI = dni,
                    MAIL = mail,
                    HABILITADO = true,
                    TELEFONO = telefono,
                    DIRECCION = direccion,
                    FECHA_NAC = fechaNac
                };
               
             
                if (dbCtx.CHOFERES.Any(c => c.DNI == cho.DNI))
                    throw new ExisteClienteException("Ya existe un cliente con el mismo TELEFONO");
                // Crear el usuario correspondiente.


                Random r;
                bool usuarioInexistente = true;
                string nombreUsuario = String.Empty;

                while (usuarioInexistente)
                {
                    r = new Random(DateTime.Now.Second);
                    nombreUsuario = UserGenerator.GenerateLowerCaseString(r);
                    usuarioInexistente = dbCtx.USUARIOS.Any(u => u.NOMBRE == nombreUsuario);
                }


                USUARIO usu = new USUARIO()
                {
                    CANT_FALLAS = 0,
                    HABILITADO = true,
                    NOMBRE = nombreUsuario,
                    PASSWORD = UserGenerator.SHA256Encrypt(nombreUsuario),
                    ROLES = dbCtx.ROLES.Where(rol => rol.NOMBRE.ToLower().Contains("chofer")).Take(1).ToList()
                };

                usu.CHOFERES.Add(cho);
                dbCtx.CHOFERES.Add(cho);
                dbCtx.USUARIOS.Add(usu);       
                dbCtx.CHOFERES.Add(cho);

                dbCtx.SaveChanges();

                return nombreUsuario;

            }
        }

        public void AbrirForm()
        {
            new Abm_ChoferCliente.AltaModificacion(this).ShowDialog();
        }

        #endregion

        #region Busqueda y modificacion
        public IList<GridData> Buscar(string busqueda)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var choferes = dbCtx.CHOFERES.Where(c => c.NOMBRE.Contains(busqueda)).Select(o =>
                    new GridData { idCliente = o.ID_CHOFER, nombre = o.NOMBRE, apellido = o.APELLIDO, dni = o.DNI }).ToList();


                return choferes;

            }
        }


        public void Actualizar(int p)
        {
            new Abm_ChoferCliente.AltaModificacion(this).ShowDialog();
        }

        #endregion






      
    }
}
