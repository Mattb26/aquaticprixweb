using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Net;

namespace Services
{
    public class Contacto
    {
        public bool Agregar(Entidades.Contacto contacto)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;

            try
            {
                client = new RestClient(ConfigurationManager.AppSettings["URI_CONTACTO"]);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.POST);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(contacto), ParameterType.RequestBody);

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
    }
}
