using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task_3.Services
{
    public class LocationService : ILocationService
    {


        private string baseUrl = null;
        private string uri = null;
        static HttpClient client = new HttpClient();

        public LocationService(String baseUrl, String uri)
        {
            this.baseUrl = baseUrl; //https://www.metaweather.com
            this.uri = uri; //api/location/{id}
        }


        public async Task<object> GetData(Dictionary<String, String> headers, Dictionary<String, String> pathVariables, Dictionary<String, String> parameters)
        {
            var client = new RestClient(this.baseUrl);
            var request = new RestRequest(this.uri);
            foreach (var item in headers)
            {
                request.AddHeader(item.Key, item.Value);
            }

            foreach (var item in pathVariables)
            {
                request.AddParameter(item.Key, item.Value, ParameterType.UrlSegment);
            }

            foreach (var item in parameters)
            {
                request.AddParameter(item.Key, item.Value, ParameterType.QueryString);
            }
            var response = client.Get(request);
            return response.Content;
        }

    }
}
