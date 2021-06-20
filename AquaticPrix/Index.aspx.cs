﻿using AquaticPrix.Entidades;
using AquaticPrix.Negocio;
using System;
using System.Web.Services;

namespace AquaticPrix
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static bool Alta(string nombre, string apellido, string fechaNacimiento, string nick, string clave, string correo)
        {
            Entidades.PersonaUsuario usuario;
            Negocio.Usuario user;

            try
            {
                usuario = new Entidades.PersonaUsuario();

                usuario.Nombre = nombre;
                usuario.Apellido = apellido;
                usuario.FechaNacimiento = Convert.ToDateTime(fechaNacimiento);
                usuario.Usuario = new Entidades.Usuario();
                usuario.Usuario.NombreUsuario = nick;
                usuario.Usuario.Clave =  Seguridad.Encriptar(clave);
                usuario.CorreoElectronico = correo;

                user = new Negocio.Usuario();
                return user.Agregar(usuario);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [WebMethod]
        public static bool AgregarContacto(string nombre, string correo, string asunto, string msj)
        {
            Entidades.Contacto contac;
            Negocio.Contacto contacto;
            try
            {
                contac = new Entidades.Contacto
                {
                    Asunto = asunto,
                    CorreoElectronico = correo,
                    Mensaje = msj,
                    Nombre = nombre

                };

                contacto = new Negocio.Contacto();
                return contacto.Enviar(contac);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}