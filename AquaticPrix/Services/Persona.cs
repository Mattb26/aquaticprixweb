using RestSharp;
using System;
using System.Net;

namespace AquaticPrix.Services
{
    public class Persona
    {
        public bool Agregar(Entidades.Usuario usuario)
        {
            RestClient client;
            RestRequest request;
            IRestResponse queryResult;
            string uriAPI = string.Empty;


            try
            {
                //if (opcion == 1) uriAPI = ConfigurationManager.AppSettings["URI_LISTA_PROVEEDOR_BANCOS"];
                //else if (opcion == 2) uriAPI = ConfigurationManager.AppSettings["URI_LISTA_PROVEEDOR_TELEFONO"];


                client = new RestClient(uriAPI);
                client.AddDefaultHeader("Content-Type", "application/json");

                request = new RestRequest(Method.GET);

                request.AddHeader("content-type", "application/json");
                request.AddHeader("Accept", "application/json");

                //if (opcion == 1) request.AddParameter("idProveedor", Id, ParameterType.UrlSegment);
                //else if (opcion == 2) request.AddParameter("idProveedor", Id, ParameterType.UrlSegment);

                request.RequestFormat = DataFormat.Json;

                queryResult = client.Execute(request);

                if (queryResult.StatusCode == HttpStatusCode.OK)
                {
                    //return queryResult.Content;
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