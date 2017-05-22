using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    class Clients : IChoferCliente
    {
        #region Propiedades
        public string Tipo { get { return "CLIENTE"; } }
        public bool ValidarMail { get { return false; } }

        public bool ValidarCodigoPostal { get { return true; } }

        public bool HabilitarCodigoPostal { get { return true; } }
        #endregion

        #region Alta

        public void AbrirForm()
        {
            new Abm_ChoferCliente.AltaModificacion(this).ShowDialog();
        }

        public string Alta(string nombre, string apellido, int dni, string mail, string direccion, int codPostal, DateTime fechaNac, int telefono)
        {

            using (var dbCtx = new GD1C2017Entities())
            {
                CLIENTE cli = new CLIENTE()
                {
                    NOMBRE = nombre,
                    APELLIDO = apellido,
                    DNI = dni,
                    MAIL = String.IsNullOrEmpty(mail) ? null : mail,
                    HABIILITADO = true,
                    TELEFONO = telefono,
                    DIRECCION = direccion,
                    FECHA_NAC = fechaNac,
                    COD_POSTAL = codPostal
                };


                // Validar que no exista ningun cliente con el mismo DNI y telefono?
                if (dbCtx.CLIENTES.Any(c => c.DNI == cli.DNI))
                    throw new ExisteClienteException("Ya existe un cliente con el mismo DNI");
                if (dbCtx.CLIENTES.Any(c => c.TELEFONO == cli.TELEFONO))
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
                    PASSWORD = UserGenerator.SHA256Encrypt(nombreUsuario)
                };
                
                usu.CLIENTES.Add(cli);
                dbCtx.CLIENTES.Add(cli);
                dbCtx.USUARIOS.Add(usu);
                

                dbCtx.SaveChanges();

                return nombreUsuario;

            }



        }
        #endregion

        #region Busqueda y modificacion

        public IList<GridData> Buscar(string busqueda)
        {

            using (var dbCtx = new GD1C2017Entities())
            {
                var clientes = dbCtx.CLIENTES.Where(c => c.NOMBRE.Contains(busqueda)).Select(o =>
                    new GridData { idCliente = o.ID_CLIENTE, nombre = o.NOMBRE, apellido = o.APELLIDO, dni = o.DNI }).ToList();


                return clientes;

            }


        }


        public void Actualizar(int p)
        {
            throw new NotImplementedException();
        }

        #endregion



    }

    public class GridData
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public decimal dni { get; set; }
    }

    public class UserGenerator
    {
        public const int size = 5;
        public const string LowerCaseAlphabet = "abcdefghijklmnopqrstuvwyxz";
        public const string UpperCaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string GenerateUpperCaseString(Random rng)
        {
            return GenerateString(rng, UpperCaseAlphabet);
        }

        public static string GenerateLowerCaseString(Random rng)
        {
            return GenerateString(rng, LowerCaseAlphabet);
        }

        public static string GenerateString(Random rng, string alphabet)
        {
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = alphabet[rng.Next(alphabet.Length)];
            }
            return new string(chars);
        }

        public static byte[] SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            return hashedBytes;            
        }
    }
}
