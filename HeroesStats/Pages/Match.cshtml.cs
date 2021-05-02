using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroesStats.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HeroesStats.Pages
{
    public class MatchModel : PageModel
    {
        public Match Match { get; set; }

        public void OnGet()
        {
            Match = new Match()
            {
                Date = new DateTime(2021, 5, 1),
                NumberInSeries = 3,
                BestOfN = 5,
                Map = new Map()
                {
                    Name = "Tomb of the Spider Queen"
                },
                TeamA = new Team()
                {
                    Name = "WildHeart Esports"
                },
                TeamB = new Team()
                {
                    Name = "Chilly Mountain"
                }
            };
        }
    }
}
