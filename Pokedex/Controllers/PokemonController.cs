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

        [Route("")]
        [Route("GetPokemon")]
        [HttpGet]
        public async Task<ActionResult<object>> GetPokemon()
        {
            return service.GetPokemonsAsync().Result;
        }

        [Route("GetPokemonById")]
        [HttpGet]
        public async Task<ActionResult<object>> GetPokemonById(int id)
        {
            return service.GetPokemon(id).Result;
        }
    }
}
