using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class BoxScore
    {
        public Game Game { get; set; }
        public Coach AwayTeamCoach { get; set; }
        public Coach HomeTeamCoach { get; set; }
        public Referee MainReferee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }
        public Referee FourthReferee { get; set; }
        public Referee AdditionalAssistantReferee1 { get; set; }
        public Referee AdditionalAssistantReferee2 { get; set; }
        public IList<Lineup> Lineups { get; set; }
        public IList<Goal> Goals { get; set; }
        public IList<Booking> Bookings { get; set; }
        public IList<PenaltyShootout> PenaltyShootouts { get; set; }
        public IList<TeamGame> TeamGames { get; set; }
        public IList<PlayerGame> PlayerGames { get; set; }
    }
}