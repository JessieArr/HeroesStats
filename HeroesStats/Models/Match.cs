using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesStats.Models
{
    public class Match
    {
        public DateTime Date { get; set; }
        public int NumberInSeries { get; set; }
        public int BestOfN { get; set; }
        public Map Map { get; set; }
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
    }
}
