using Entidades;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace Services
{
    public class Usuario
    {
        public bool Agregar(Entidades.Usuario usuario)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;

            try
            {

                client = new RestClient(ConfigurationManager.AppSettings["URI_PERSONAS"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.POST);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(usuario), ParameterType.RequestBody);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;

                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool VerificarExisteUsuario(string usuario)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;

            try
            {

                client = new RestClient(ConfigurationManager.AppSettings["URI_VERIFICARUSUARIO"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.GET);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("usuario", usuario, ParameterType.QueryString);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                else if (queryResult.StatusCode == HttpStatusCode.BadRequest)
                {

                    return false;

                }
                else
                {

                    return false;
                }


            }
            catch (Exception ex)
            {


                throw;
            }
            finally
            {
                client = null;
                request = null;
                queryResult = null;
            }
        }

        public bool VerificarExisteCuenta(string correoElectronico)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;

            try
            {

                client = new RestClient(ConfigurationManager.AppSettings["URI_VERIFICARCUENTA"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.GET);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("mail", correoElectronico, ParameterType.QueryString);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                else if (queryResult.StatusCode == HttpStatusCode.BadRequest)
                {
                    return false;

                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {


                throw;
            }
            finally
            {
                client = null;
                request = null;
                queryResult = null;
            }
        }

        public Entidades.PersonaUsuario Login(Entidades.Usuario usuario)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;

            try
            {

                client = new RestClient(ConfigurationManager.AppSettings["URI_LOGINUSUARIO"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.POST);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(usuario), ParameterType.RequestBody);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {

                    return JsonConvert.DeserializeObject<Entidades.PersonaUsuario>(queryResult.Content);
                }
                else
                {
                    return null;

                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool CambioClave(Entidades.UsuarioClave usuarioClave)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;

            try
            {

                client = new RestClient(ConfigurationManager.AppSettings["URI_USUARIOCAMBIOCLAVE"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.PUT);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(usuarioClave), ParameterType.RequestBody);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {

                    return true;
                }
                else
                {
                    return false;

                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IList<Entidades.Estadisticas> ListadoEstadisticas(Int32 idUsuario = 0)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;
            string url = string.Empty;


            try
            {
                //URI_USUARIOESTADISTICAS_IDUSUARIO

                if (idUsuario != 0)
                {
                    url = ConfigurationManager.AppSettings["URI_USUARIOESTADISTICAS_IDUSUARIO"];
                }
                else
                {
                    url = ConfigurationManager.AppSettings["URI_USUARIOESTADISTICAS"];
                }

                client = new RestClient(url);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.GET);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                if (idUsuario != 0)
                {
                    request.AddParameter("idUsuario", idUsuario, ParameterType.UrlSegment);
                }

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<IList<Estadisticas>>(queryResult.Content);
                }
                else
                {
                    return null;

                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
