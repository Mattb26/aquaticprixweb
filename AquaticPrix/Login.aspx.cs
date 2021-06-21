using AquaticPrix.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AquaticPrix
{
    public partial class Login : System.Web.UI.Page
    {
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
                    }
                    else 
                    {
                        
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