using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int RoudId { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
        public string Group { get; set; }
        public int? AwayTeamId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? VenueId { get; set; }
        public string Day { get; set; }
        public string DateTime { get; set; }
        public string Status { get; set; }
        public int Week { get; set; }
        public string Period { get; set; }
        public int? Clock { get; set; }
        public string Winner { get; set; }
        public string VenueType { get; set; }
        public string AwayTeamKey { get; set; }
        public string AwayTeamName { get; set; }
        public string AwayTeamCountryCode { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? AwayTeamScorePeriod1 { get; set; }
        public int? AwayTeamScorePeriod2 { get; set; }
        public int? AwayTeamScoreExtraTime { get; set; }
        public int? AwayTeamScorePenalty { get; set; }
        public string HomeTeamKey { get; set; }
        public string HomeTeamName { get; set; }
        public string HomeTeamCountryCode { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? HomeTeamScorePeriod1 { get; set; }
        public int? HomeTeamScorePeriod2 { get; set; }
        public int? HomeTeamScoreExtraTime { get; set; }
        public int? HomeTeamScorePenalty { get; set; }
        public int? Attendance { get; set; }
        public string Updated { get; set; }
        public string UpdatedUtc { get; set; }
        public int GlobalGameId { get; set; }
        public int GlobalAwayTeamId { get; set; }
        public int GlobalHomeTeamId { get; set; }
    }
}