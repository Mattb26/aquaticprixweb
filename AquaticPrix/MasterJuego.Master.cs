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

                    if (personaUsuario != null)
                    {
                        lblUsuario.Text = personaUsuario.Usuario.NombreUsuario;
                        HabilitarMenu(personaUsuario.Usuario.Estado);
                    }
                    else
                    {
                        Response.Redirect("~/Login.aspx", false);
                    }

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
        private void HabilitarMenu(int estado)
        {
            try
            {
                if (estado == 2 || estado == 3)
                {
                    mnAdministracion.Visible = true;
                    if (estado == 3)
                    {
                        mnAdministracionAgregar.Visible = true;
                    }
                    else 
                    {
                        mnAdministracionAgregar.Visible = false;
                    }
                    
                }
                else
                {
                    mnAdministracion.Visible = false;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}