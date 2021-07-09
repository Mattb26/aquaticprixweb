using Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio
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
            Services.Usuario usuario;
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

        public Entidades.PersonaUsuario Login(Entidades.Usuario usuario)
        {
            Services.Usuario usuarioLogin;
            try
            {
                usuarioLogin = new Services.Usuario();
                return usuarioLogin.Login(usuario);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PersonasListado(Int32 codPerfil, int op)
        {
            Services.Persona persona;

            try
            {
                persona = new Services.Persona();

                IList<PersonaUsuario> personaUsuario = persona.Listado(codPerfil, op);

                using (DataTable dt = new DataTable())
                {
                    dt.Columns.Add("id", typeof(string));
                    dt.Columns.Add("nombre", typeof(string));
                    dt.Columns.Add("apellido", typeof(string));
                    dt.Columns.Add("correoElectronico", typeof(string));
                    dt.Columns.Add("fechaNacimiento", typeof(string));
                    dt.Columns.Add("idUsuario", typeof(string));
                    dt.Columns.Add("nombreUsuario", typeof(string));
                    dt.Columns.Add("estado", typeof(string));

                    if (personaUsuario != null)
                    {
                        foreach (var item in personaUsuario)
                        {
                            DataRow NewRow = dt.NewRow();
                            NewRow["id"] = item.IdPersona;
                            NewRow["nombre"] = item.Nombre;
                            NewRow["apellido"] = item.Apellido;
                            NewRow["correoElectronico"] = item.CorreoElectronico;
                            NewRow["fechaNacimiento"] = Convert.ToDateTime(item.FechaNacimiento).ToString("dd/MM/yyyy");
                            NewRow["idUsuario"] = item.Usuario.IdUsuario;
                            NewRow["nombreUsuario"] = item.Usuario.NombreUsuario;
                            NewRow["estado"] = Perfil(item.Usuario.Estado);
                            dt.Rows.Add(NewRow);
                        }
                    }

                    return dt;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw;
            }

        }

        public string Perfil(Int32 id)
        {
            try
            {
                switch (id)
                {
                    case 1:
                        return "Usuario";
                    case 2:
                        return "Operador";
                    case 3:
                        return "Administrador";
                    default:
                        return "Sin Perfil";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CambioClave(Entidades.UsuarioClave usuarioClave)
        {
            Services.Usuario usuario;
            try
            {
                usuario = new Services.Usuario();

                return usuario.CambioClave(usuarioClave);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable Estadisticas(Int32 idUsuario = 0)
        {

            Services.Usuario usuario;

            try
            {
                usuario = new Services.Usuario();

                IList<Entidades.Estadisticas> estadisticas = usuario.ListadoEstadisticas(idUsuario);

                using (DataTable dt = new DataTable())
                {
                    dt.Columns.Add("nombreUsuario", typeof(string));
                    dt.Columns.Add("posicion", typeof(string));
                    dt.Columns.Add("perdido", typeof(string));
                    dt.Columns.Add("promedioPartidas", typeof(string));
                    dt.Columns.Add("bajas", typeof(string));
                    dt.Columns.Add("caidas", typeof(string));
                    dt.Columns.Add("promediobaja", typeof(string));
                    dt.Columns.Add("promedioCaidas", typeof(string));
                    dt.Columns.Add("fecha", typeof(string));

                    if (estadisticas != null)
                    {
                        foreach (var item in estadisticas)
                        {
                            DataRow NewRow = dt.NewRow();
                            NewRow["nombreUsuario"] = item.NombreUsuario;
                            NewRow["posicion"] = item.Posicion;
                            NewRow["perdido"] = item.Perdido;
                            NewRow["promedioPartidas"] = item.PromedioPartidas;
                            NewRow["bajas"] = item.Bajas;
                            NewRow["promediobaja"] = item.Promediobaja;
                            NewRow["caidas"] = item.Caidas;
                            NewRow["promedioCaidas"] = item.PromedioCaidas;
                            NewRow["fecha"] = Convert.ToDateTime(item.Fecha).ToString("dd/MM/yyyy");
                            dt.Rows.Add(NewRow);
                        }
                    }

                    return dt;
                }

            }
            catch (Exception ex)
            {
                return null;
                throw;
            }

        }
    }
}
