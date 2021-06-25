using AquaticPrix.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AquaticPrix.Administracion
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            Negocio.Combo combo;
            try
            {
                combo = new Negocio.Combo();
                drpdPerfil.AppendDataBoundItems = true;
                drpdPerfil.Items.Add("Seleccione...");
                drpdPerfil.DataSource = combo.Perfils();
                drpdPerfil.DataTextField = "Descripcion";
                drpdPerfil.DataValueField = "IdPerfil";
                drpdPerfil.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            Entidades.PersonaUsuario personaUsuario;
            Negocio.Usuario usuarioAlta;

            try
            {
                personaUsuario = new Entidades.PersonaUsuario();
                personaUsuario.Nombre = txtNombre.Value.Trim();
                personaUsuario.Apellido = txtApellido.Value.Trim();
                personaUsuario.CorreoElectronico = txtCorreoElectronico.Value.Trim();
                personaUsuario.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Value.Trim());

                personaUsuario.Usuario = new Entidades.Usuario();
                personaUsuario.Usuario.NombreUsuario = txtLogin.Value.Trim();
                personaUsuario.Usuario.Clave = Seguridad.Encriptar(txtClave.Value.Trim());
                personaUsuario.Usuario.Estado = int.Parse(drpdPerfil.SelectedValue);

                usuarioAlta = new Usuario();

                usuarioAlta.Agregar(personaUsuario);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}