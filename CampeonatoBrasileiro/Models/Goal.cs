using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Goal
    {
        public int GoalId { get; set; }
        public int GameId { get; set; }
        public int TeamId { get; set; }
        public int? PlayerId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int? AssistedByPlayerId1 { get; set; }
        public string AssistedByPlayerName1 { get; set; }
        public int? AssistedByPlayerId2 { get; set; }
        public string AssistedByPlayerName2 { get; set; }
        public int? GameMinute { get; set; }
        public int? GameMinuteExtra { get; set; }

    }
}