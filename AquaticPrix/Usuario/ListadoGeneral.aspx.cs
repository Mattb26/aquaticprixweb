using System;

namespace AquaticPrix.Usuario
{
    public partial class ListadoGeneral : System.Web.UI.Page
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
                usuario = new Negocio.Usuario();
                grvListadoGeneral.DataSource = usuario.Estadisticas();
                grvListadoGeneral.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}