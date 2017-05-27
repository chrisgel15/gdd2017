﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Abm_ChoferCliente;

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

        public string Alta(AltaModificacionData altaData)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                CHOFERE cho = new CHOFERE()
                {
                    NOMBRE = altaData.nombre,
                    APELLIDO = altaData.apellido,
                    DNI = altaData.dni,
                    MAIL = altaData.mail,
                    HABILITADO = true,
                    TELEFONO = altaData.telefono,
                    DIRECCION = altaData.direccion,
                    FECHA_NAC = altaData.fechaNac
                };
               
             
                // TODO: Esta restriccion es solo para CLIENTES ???
                //if (dbCtx.CHOFERES.Any(c => c.DNI == cho.DNI))
                //    throw new ExisteClienteException("Ya existe un chofer con el mismo TELEFONO");
                
                
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
            decimal dni = 0;
            decimal.TryParse(busqueda, out dni);
            using (var dbCtx = new GD1C2017Entities())
            {
                var choferes = dbCtx.CHOFERES.Where(c => c.NOMBRE.Contains(busqueda)
                                        || c.APELLIDO.Contains(busqueda) || c.DNI == dni).Select(o =>
                    new GridData { id = o.ID_CHOFER, nombre = o.NOMBRE, apellido = o.APELLIDO, dni = o.DNI, habilitado = o.HABILITADO }).ToList();


                return choferes;

            }
        }

        public void Habilitar(int id)
        {
            using (var dbCtx = new GD1C2017Entities())
            {
                var chof = dbCtx.CHOFERES.First(ch => ch.ID_CHOFER == id);
                chof.HABILITADO = !chof.HABILITADO;
                dbCtx.SaveChanges();
            }
        }

        public AltaModificacionData CompletaCamposActualizar(int id)
        {
            CHOFERE chofer;

            using (var dbCtx = new GD1C2017Entities())
            {
                chofer = dbCtx.CHOFERES.First(c => c.ID_CHOFER == id);
            }

            return new AltaModificacionData()
            {
                nombre = chofer.NOMBRE,
                apellido = chofer.APELLIDO,
                dni = (int)chofer.DNI,
                mail = chofer.MAIL,
                direccion = chofer.DIRECCION,
                telefono = (int)chofer.TELEFONO,
                codigoPostal = null,
                fechaNac = chofer.FECHA_NAC
            };
        }

        public void AbrirFormActualizar(int id)
        {
            new Abm_ChoferCliente.AltaModificacion(this, id).ShowDialog();
        }

        #endregion




        public void Modificacion(AltaModificacionData modificacionData)
        {
            using(var dbCtx = new GD1C2017Entities())
            {
                var chof = dbCtx.CHOFERES.First(c => c.ID_CHOFER == modificacionData.id);

                chof.NOMBRE = modificacionData.nombre;
                chof.APELLIDO = modificacionData.apellido;
                chof.DIRECCION = modificacionData.direccion;
                chof.DNI = modificacionData.dni;
                chof.FECHA_NAC = modificacionData.fechaNac;
                chof.MAIL = modificacionData.mail;
                chof.TELEFONO = modificacionData.telefono;

                dbCtx.SaveChanges();
            }
        }
    }
}
