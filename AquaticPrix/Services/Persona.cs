using AquaticPrix.Entidades;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace AquaticPrix.Services
{
    public class Persona
    {
        public bool Agregar(Entidades.PersonaUsuario usuario)
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

        public IList<PersonaUsuario> Listado(Int32 codPerfil, int op)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;

            try
            {
                client = new RestClient(ConfigurationManager.AppSettings["URI_LISTADOPERSONA"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.GET);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("codPerfil", codPerfil, ParameterType.UrlSegment);
                request.AddParameter("op", op, ParameterType.UrlSegment);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<IList<PersonaUsuario>>(queryResult.Content); 
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