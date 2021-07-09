using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Combo
    {
        public IList<Entidades.Perfil> Perfils()
        {
            IList<Entidades.Perfil> perfil;

            try
            {
                perfil = new List<Entidades.Perfil>()
                {
                    new Entidades.Perfil()
                    {
                        IdPerfil = 2,
                        Descripcion ="Operador"
                    },
                    new Entidades.Perfil()
                    {
                        IdPerfil = 3,
                        Descripcion ="Administrador"
                    }
                };


                return perfil;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
