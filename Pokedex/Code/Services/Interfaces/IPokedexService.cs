using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Code.Services.Interfaces
{
    interface IPokedexService
    {
        Task<object> GetPokedex();
    }
}
