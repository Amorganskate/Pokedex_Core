using Microsoft.AspNetCore.Mvc;
using Pokedex.Code.Services.Interfaces;
using Pokedex.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Pokedex.Code.Services
{
    public class PokemonService : IPokemonService
    {
        private RestClient _client;

        public PokemonService(RestClient restClient)
        {
            _client = restClient;
        }


        public async Task<object> GetPokemonsAsync()
        {
            var Request = new RestRequest("pokemon", Method.GET);
            var response = await _client.ExecuteAsync<JsonResult>(Request);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content;
            }
            return null;
        }

        public async Task<object> GetPokemon(int id)
        {
            var request = new RestRequest("pokemon/" + id.ToString());

            var response = await _client.ExecuteAsync<JsonResult>(request);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content;
            }

            return null;
        }

        public async Task<object> GetPokemon(string name)
        {
            var request = new RestRequest("pokemon/" + name);

            var response = await _client.ExecuteAsync<JsonResult>(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content;
            }

            return null;
        }

        public async Task<object> GetSpecies(string id)
        {
            var request = new RestRequest("pokemon-species/" + id);

            var response = await _client.ExecuteAsync<JsonResult>(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content;
            }

            return null;
        }
    }
}
