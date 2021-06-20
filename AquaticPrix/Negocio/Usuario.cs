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
    }
}