using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Standing
    {
        public int StandingId { get; set; }
        public int RoundId { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Scope { get; set; }
        public int? Order { get; set; }
        public int? Games { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Draws { get; set; }
        public int? GoalsScored { get; set; }
        public int? GoalsAgainst { get; set; }
        public int? GoalsDifferential { get; set; }
        public int? Points { get; set; }
    }
}