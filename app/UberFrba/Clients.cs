using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_ChoferCliente;

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

        public string Alta(AltaModificacionData altaData)
        {

            using (var dbCtx = new GD1C2017Entities())
            {
                CLIENTE cli = new CLIENTE()
                {
                    NOMBRE = altaData.nombre,
                    APELLIDO = altaData.apellido,
                    DNI = altaData.dni,
                    MAIL = String.IsNullOrEmpty(altaData.mail) ? null : altaData.mail,
                    HABIILITADO = true,
                    TELEFONO = altaData.telefono,
                    DIRECCION = altaData.direccion,
                    FECHA_NAC = altaData.fechaNac,
                    COD_POSTAL = altaData.codigoPostal
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
                    PASSWORD = UserGenerator.SHA256Encrypt(nombreUsuario),
                    ROLES = dbCtx.ROLES.Where(rol => rol.NOMBRE.ToLower().Contains("cliente")).Take(1).ToList()
                };
                
                usu.CLIENTES.Add(cli);
                dbCtx.CLIENTES.Add(cli);
                dbCtx.USUARIOS.Add(usu);              
                
                dbCtx.SaveChanges();

                return nombreUsuario;

            }



        }
        #endregion

        #region Busqueda, modificacion y baja

        public IList<GridData> Buscar(string busqueda)
        {

            decimal dni = 0;
            decimal.TryParse(busqueda, out dni);
            using (var dbCtx = new GD1C2017Entities())
            {
                var clientes = dbCtx.CLIENTES.Where(c => c.NOMBRE.Contains(busqueda) 
                                                        || c.APELLIDO.Contains(busqueda) || c.DNI == dni).Select(o =>
                    new GridData { id = o.ID_CLIENTE, nombre = o.NOMBRE, apellido = o.APELLIDO, dni = o.DNI, habilitado = o.HABIILITADO }).ToList();


                return clientes;

            }


        }

        public void AbrirFormActualizar(int id)
        {
            new Abm_ChoferCliente.AltaModificacion(this, id).ShowDialog();
        }

        public AltaModificacionData CompletaCamposActualizar(int id)
        {
            CLIENTE cliente;

            using (var dbCtx = new GD1C2017Entities())
            {
                cliente = dbCtx.CLIENTES.First(c => c.ID_CLIENTE == id);
            }

            return new AltaModificacionData()
            {
                nombre = cliente.NOMBRE,
                apellido = cliente.APELLIDO,
                dni = (int)cliente.DNI,
                mail = cliente.MAIL,
                direccion = cliente.DIRECCION,
                telefono = (int)cliente.TELEFONO,
                codigoPostal = cliente.COD_POSTAL,
                fechaNac = cliente.FECHA_NAC
            };
        }

        public void Habilitar(int id)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var cli = dbCtx.CLIENTES.First(cl => cl.ID_CLIENTE == id);
                cli.HABIILITADO = !cli.HABIILITADO;
                dbCtx.SaveChanges();
            }
        }

        #endregion



        public void Modificacion(AltaModificacionData modificacionData)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var cli = dbCtx.CLIENTES.First(c => c.ID_CLIENTE == modificacionData.id);

                cli.NOMBRE = modificacionData.nombre;
                cli.APELLIDO = modificacionData.apellido;
                cli.DIRECCION = modificacionData.direccion;
                cli.DNI = modificacionData.dni;
                cli.FECHA_NAC = modificacionData.fechaNac;
                cli.MAIL = modificacionData.mail;
                cli.TELEFONO = modificacionData.telefono;
                cli.COD_POSTAL = modificacionData.codigoPostal;

                dbCtx.SaveChanges();
            }
        }
    }

    public class GridData
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public decimal dni { get; set; }

        public bool habilitado { get; set; }
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
