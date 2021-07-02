using System;

namespace AquaticPrix.Negocio
{
    public class Contacto
    {
        public bool Enviar(Entidades.Contacto contacto)
        {
            Services.Contacto agregar;
            try
            {
                agregar = new Services.Contacto();
                return agregar.Agregar(contacto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}