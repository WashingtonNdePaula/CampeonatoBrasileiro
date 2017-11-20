using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class SeasonTeam
    {
        public int SeasonTeamId { get; set; }
        public int SeasonId { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public bool Active { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }

    }
}