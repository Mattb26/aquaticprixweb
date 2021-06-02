using AquaticPrix.Entidades;
using System;
using System.Web.Services;

namespace AquaticPrix
{
    public partial class master : System.Web.UI.MasterPage
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
    }
}