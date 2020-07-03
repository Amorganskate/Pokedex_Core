using Microsoft.AspNetCore.Mvc;
using Pokedex.Code.Services.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Pokedex.Code.Services
{
    public class PokedexService : IPokedexService
    {
        private RestClient _client;

        public PokedexService(RestClient restClient)
        {
            _client = restClient;
        }

        public async Task<object> GetPokedex()
        {
            var Request = new RestRequest("pokedex/1", Method.GET);
            var Response = await _client.ExecuteAsync<JsonResult>(Request);

            if(Response.StatusCode == HttpStatusCode.OK)
            {
                return Response.Content;
            }
            return null;
        }
    }
}
