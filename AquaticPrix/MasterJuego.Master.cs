using System;

namespace AquaticPrix
{
    public partial class MasterJuego : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entidades.PersonaUsuario personaUsuario;
            try
            {
                if (!IsPostBack)
                {
                    personaUsuario = (Entidades.PersonaUsuario)(Session["usuario"]);

                    if (personaUsuario != null)
                    {
                        lblUsuario.Text = personaUsuario.Usuario.NombreUsuario;
                    }
                    else 
                    {
                        Response.Redirect("~/NoAutorizado.aspx", false);
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