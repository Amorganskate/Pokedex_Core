using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class pokedex
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<results> results { get; set; }
    }

    public class results
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
    }
}
