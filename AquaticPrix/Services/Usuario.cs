using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Net;

namespace AquaticPrix.Services
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
                    return false;
                }
                else if (queryResult.StatusCode == HttpStatusCode.BadRequest)
                {

                    return true;

                }else
                {

                    return true;
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

                client = new RestClient(ConfigurationManager.AppSettings["URI_VERIFICARUSUARIO"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.GET);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("mail", correoElectronico, ParameterType.QueryString);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {
                    return false;
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
    }
}