using Entidades;
using Negocio;
using System;
using System.Web.UI;

namespace AquaticPrix.Administracion
{
    public partial class CambioClave : System.Web.UI.Page
    {
        //ErrorMensaje
        private void MensajeCorrecto(string msj)
        {
            try
            {
                string script = "CorrectoMensajeMsj('"+ msj + "');";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "CorrectoMensajes", script, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void MensajeError(string msj)
        {
            try
            {
                string script = "ErrorMensaje('" + msj + "');";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "CorrectoMensajeError", script, true);
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Entidades.PersonaUsuario personaUsuario = (Entidades.PersonaUsuario)(Session["usuario"]);
                    txtUsuario.Value = personaUsuario.Usuario.NombreUsuario;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioClave usuarioClave;
            Entidades.PersonaUsuario personaUsuario;
            Negocio.Usuario usuario;
                 
            try
            {
                if ((txtClaveAnterior.Value.Trim() != txtConfirmarClave.Value.Trim()) &&
                    (txtClaveAnterior.Value.Trim() != txtNuevaClave.Value.Trim()))
                {
                    if ((txtNuevaClave.Value.Trim() != string.Empty) &&
                        (txtConfirmarClave.Value.Trim() != string.Empty))
                    {
                        if ((txtClaveAnterior.Value.Trim() != string.Empty) &&
                           (txtNuevaClave.Value.Trim() == txtConfirmarClave.Value.Trim()))
                        {
                            personaUsuario = (Entidades.PersonaUsuario)(Session["usuario"]);
                            usuarioClave = new UsuarioClave();
                            usuarioClave.Clave = Seguridad.Encriptar(txtClaveAnterior.Value.Trim());
                            usuarioClave.ClaveNueva = Seguridad.Encriptar(txtConfirmarClave.Value.Trim());
                            usuarioClave.IdUsuario = personaUsuario.Usuario.IdUsuario;
                            usuarioClave.NombreUsuario = personaUsuario.Usuario.NombreUsuario;
                            usuarioClave.Estado = personaUsuario.Usuario.Estado;
                            usuario = new Negocio.Usuario();

                            if (usuario.CambioClave(usuarioClave))
                            {
                                //Se realizo correctamente el cambio de clave
                                MensajeCorrecto("Se realizó correctamente el cambio de clave");
                                return;
                            }
                            else
                            {
                                //Error al realizar el cambio de clave
                                MensajeError("No se realizó el cambio de clave");
                                return;
                            }
                        }
                        else
                        {
                            //no coincide las nuevas claves
                            MensajeError("La nueva clave ingresada no coincide");
                            return;
                        }
                    }
                    else
                    {
                        //No se puede enviar un clave vacia
                        MensajeError("No se puede cambiar la clave por un valor vacío");
                        return;
                    }

                }
                else
                {
                    //La nueva clave no puede ser igual a la anterior
                    MensajeError("La nueva clave no puede ser igual que la anterior");
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}