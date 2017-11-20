using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class TeamGame : TeamSeason
    {
        public int? GameId { get; set; }
        public int? OpponentId { get; set; }
        public string Opponent { get; set; }
        public string Day { get; set; }
        public string Datetime { get; set; }
        public string HomeOrAway { get; set; }
        public bool? IsGameOver { get; set; }
        public int? GlobalGameId { get; set; }
        public int? GlobalOpponentId { get; set; }
    }
}