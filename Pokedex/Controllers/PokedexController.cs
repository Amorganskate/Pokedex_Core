using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Code.Services;

namespace Pokedex.Controllers
{
    [Route("api/pokedex")]
    [ApiController]
    public class PokedexController : ControllerBase
    {
        private const string BaseUrl = "https://pokeapi.co/api/v2/";
        PokedexService service = new PokedexService(new RestSharp.RestClient(BaseUrl));

        [HttpGet]
        public async Task<ActionResult<object>> GetPokedex()
        {
            return await service.GetPokedex();
        }
    }
}
