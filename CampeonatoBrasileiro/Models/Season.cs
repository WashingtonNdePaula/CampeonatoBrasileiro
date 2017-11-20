using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class SeasonClass
    {
        public int SeasonId { get; set; }
        public int CompetitionId { get; set; }
        public int Season { get; set; }
        public string Name { get; set; }
        public string CompetitionName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool CurrentSeason { get; set; }
        public IList<Round> Rounds { get; set; }
        public SeasonClass()
        {
            Rounds = new List<Round>();
        }
    }
}