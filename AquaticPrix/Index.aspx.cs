using AquaticPrix.Entidades;
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
        public static bool Alta(Usuario usuario)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [WebMethod]
        //public static bool AgregarContacto(Entidades.Contacto contacto)
        public static bool AgregarContacto(string nombre, string correo, string asjunto, string msj)
        {
            try
            {

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}