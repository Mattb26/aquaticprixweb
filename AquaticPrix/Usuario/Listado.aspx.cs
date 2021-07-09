using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AquaticPrix.Usuario
{
    public partial class Listado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                Cargar();
            }
        }
        private void Cargar()
        {
            Negocio.Usuario usuario;

            try
            {
                Entidades.PersonaUsuario personaUsuario = (Entidades.PersonaUsuario)(Session["usuario"]);

                usuario = new Negocio.Usuario();
                grvListadoGeneral.DataSource = usuario.Estadisticas(personaUsuario.Usuario.IdUsuario);
                grvListadoGeneral.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}