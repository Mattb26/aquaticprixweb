using System;

namespace AquaticPrix
{
    public partial class MasterJuego : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnCerrarSession.ServerClick += BtnCerrarSession_ServerClick;
                
            Entidades.PersonaUsuario personaUsuario;
            
            try
            {
                if (!IsPostBack)
                {
                    personaUsuario = (Entidades.PersonaUsuario)(Session["usuario"]);

                    //if (personaUsuario != null)
                    //{
                    //    lblUsuario.Text = personaUsuario.Usuario.NombreUsuario;
                    //}
                    //else 
                    //{
                    //    Response.Redirect("~/NoAutorizado.aspx", false);
                    //}
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnCerrarSession_ServerClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Index.aspx", false);
        }
    }
}