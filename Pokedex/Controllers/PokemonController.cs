using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Code.Services;
using Pokedex.Models;
using RestSharp;

namespace Pokedex.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private const string BaseUrl = "https://pokeapi.co/api/v2/";
        PokemonService service = new PokemonService(new RestClient(BaseUrl));

        
        [HttpGet]
        public async Task<ActionResult<object>> GetPokemon()
        {
            
            var result = await service.GetPokemonsAsync();

            return result;
        }

        [Route("GetPokemonByID")]
        public async Task<ActionResult<object>> GetPokemon(int id)
        {
            var result = await service.GetPokemon(id);

            return result;
        }

        [Route("species")]
        [HttpGet]
        public async Task<ActionResult<object>> GetSpecies(string id)
        {
            var result = await service.GetSpecies(id);

            return result;
        }

        [Route("GetPokemonByName")]
        [HttpGet]
        public async Task<ActionResult<object>> GetPokemonByName(string name)
        {
            var result = await service.GetPokemon(name);

            return result;
        }
    }
}
