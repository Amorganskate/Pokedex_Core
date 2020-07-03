using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Code.Services.Interfaces
{
    interface IPokemonService
    {
        Task<object> GetPokemonsAsync();
        Task<object> GetPokemon(int id);
        Task<object> GetPokemon(string name);
    }
}
