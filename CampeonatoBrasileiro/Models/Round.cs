using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Round
    {
        public int RoundId { get; set; }
        public int SeasonId { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int CurrentWeek { get; set; }
        public bool CurrentRound { get; set; }
    }
}