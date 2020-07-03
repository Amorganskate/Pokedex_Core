using Microsoft.Extensions.DependencyInjection;
using Pokedex.Code.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Code.Services
{
    public static class Bootstrapper
    {
        public static void UseServices(this IServiceCollection services)
        {
            services.AddHttpClient<IPokemonService, PokemonService>();
        }
    }
}
