using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesStats.Models
{
    public class Map
    {
        public string Name { get; set; }
        public static List<Map> Maps { get; set; } = new List<Map>()
        {
            new Map()
            {
                Name = "Tomb of the Spider Queen"
            }
        };
    }
}
