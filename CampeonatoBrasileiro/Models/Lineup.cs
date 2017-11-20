using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Lineup
    {
        public int LineupId { get; set; }
        public int GameId { get; set; }
        public string Type { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int? ReplacedPlayerId { get; set; }
        public string ReplacedPlayerName { get; set; }
        public int? GameMinute { get; set; }
        public int? GameMinuteExtra { get; set; }
        public int? PitchPositionHorizontal { get; set; }
        public int? PitchPositionVertical { get; set; }

    }
}