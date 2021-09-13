using Negocio;
using System;
using System.Web.UI;

namespace AquaticPrix
{
    public partial class Login : System.Web.UI.Page
    {
        private void MensajeError()
        {
            try
            {
                string script = "ErrorMensajes();";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ErrorMensajes1", script, true);
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            Negocio.Usuario usuario;
            Entidades.Usuario usuaroLogins;
            Entidades.PersonaUsuario personaUsuario;
            try
            {
                if ((!txtUser.Value.Trim().Equals(string.Empty)) && 
                    (!txtPassword.Value.Trim().Equals(string.Empty))) 
                {
                    usuaroLogins = new Entidades.Usuario();
                    usuaroLogins.NombreUsuario = txtUser.Value.Trim();
                    usuaroLogins.Clave = Seguridad.Encriptar(txtPassword.Value.Trim());

                    usuario = new Negocio.Usuario();
                    personaUsuario = usuario.Login(usuaroLogins);

                    if (personaUsuario != null)
                    {
                        Session["usuario"] = personaUsuario;
                        Response.Redirect("~/Default.aspx", false);
                    }
                    else 
                    {
                        MensajeError();
                        return;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}