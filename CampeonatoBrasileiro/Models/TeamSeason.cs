using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class TeamSeason
    {
        public int StatId { get; set; }
        public int SeasonId { get; set; }
        public int Season { get; set; }
        public int? RoundId { get; set; }
        public int? TeamId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public int? GlobalTeamId { get; set; }
        public string Updated { get; set; }
        public string UpdatedUtc { get; set; }
        public int? Games { get; set; }
        public decimal? FantasyPoints { get; set; }
        public decimal? FantasyPointsDraftKings { get; set; }
        public decimal? FantasyPointsYahoo { get; set; }
        public decimal? FantasyPointsMondogoal { get; set; }
        public decimal? Minutes { get; set; }
        public decimal? Goals { get; set; }
        public decimal? Assists { get; set; }
        public decimal? Shots { get; set; }
        public decimal? ShotsOnGoal { get; set; }
        public decimal? YellowCards { get; set; }
        public decimal? RedCards { get; set; }
        public decimal? YellowRedCards { get; set; }
        public decimal? Crosses { get; set; }
        public decimal? TacklesWon { get; set; }
        public decimal? Interceptions { get; set; }
        public decimal? OwnGoals { get; set; }
        public decimal? Fouls { get; set; }
        public decimal? Fouled { get; set; }
        public decimal? Offsides { get; set; }
        public decimal? Passes { get; set; }
        public decimal? PassesCompleted { get; set; }
        public decimal? LastManTackle { get; set; }
        public decimal? CornersWon { get; set; }
        public decimal? BlockedShots { get; set; }
        public decimal? Touches { get; set; }
        public decimal? DefenderCleanSheets { get; set; }
        public decimal? GoalKeeperSaves { get; set; }
        public decimal? GoalKeeperGoalAgainst { get; set; }
        public decimal? GoalKeeperSingleGoalAgainst { get; set; }
        public decimal? GoalKeeperCleanSheets { get; set; }
        public decimal? GoalKeeperWins { get; set; }
        public decimal? PenaltyKickGoals { get; set; }
        public decimal? PenaltyKickMisses { get; set; }
        public decimal? PenaltyKickSaves { get; set; }
        public decimal? PenaltyKickWon { get; set; }
        public decimal? PenaltiesConceded { get; set; }
        public decimal? Score { get; set; }
        public decimal? OpponentScore { get; set; }
    }
}