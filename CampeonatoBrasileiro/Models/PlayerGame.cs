using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class PlayerGame : PlayerSeason
    {
        public int? Jersey { get; set; }
        public bool? Captain { get; set; }
        public bool? Suspension { get; set; }
        public string SuspensionReason { get; set; }
        public int? FanDuelSalary { get; set; }
        public int? DraftkingsSalary { get; set; }
        public int? MondogoalSalary { get; set; }
        public string FanDuelPosition { get; set; }
        public string DraftKingsPosition { get; set; }
        public string YahooPosition { get; set; }
        public string MondogoalPosition { get; set; }
        public string InjuryStatus { get; set; }
        public string InjuryBodyPart { get; set; }
        public string InjuryNotes { get; set; }
        public string InjuryStartDate { get; set; }
        public int? GameId { get; set; }
        public int? OpponentId { get; set; }
    }
}