using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Competition
    {
        public int CompetitionId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public SeasonClass CurrentSeason { get; set; }
        public IList<Team> Teams { get; set; }
        public IList<Game> Games { get; set; }
    }
}