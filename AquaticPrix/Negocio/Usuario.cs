using System;

namespace AquaticPrix.Negocio
{
    public class Usuario
    {
        public bool Agregar(Entidades.PersonaUsuario usuario)
        {
            Services.Persona persona;
            try
            {
                persona = new Services.Persona();
                return persona.Agregar(usuario);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Verificar(string nick)
        {
            Services.Usuario usuario ;
            try
            {
                usuario = new Services.Usuario();
                return usuario.VerificarExisteUsuario(nick);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool VerificarCorreo(string email)
        {
            Services.Usuario usuario;
            try
            {
                usuario = new Services.Usuario();
                return usuario.VerificarExisteCuenta(email);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}