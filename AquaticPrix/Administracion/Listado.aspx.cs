using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AquaticPrix.Administracion
{
    public partial class Listado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            Negocio.Usuario usuario;
            Entidades.PersonaUsuario personaUsuario;
            int op = 0;

            try
            {
                usuario = new Negocio.Usuario();
                personaUsuario = (Entidades.PersonaUsuario)(Session["usuario"]);

                if (personaUsuario.Usuario.Estado == 2)
                {
                    op = 2;
                }
                else if (personaUsuario.Usuario.Estado == 3)
                {
                    op = 1;
                }

                grvListadoGeneral.DataSource = usuario.PersonasListado(personaUsuario.Usuario.Estado, op);
                grvListadoGeneral.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}