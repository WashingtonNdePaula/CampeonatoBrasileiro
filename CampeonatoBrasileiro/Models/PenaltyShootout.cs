using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class PenaltyShootout
    {
        public int PenaltyShootoutId { get; set; }
        public int GameId { get; set; }
        public string Type { get; set; }
        public int TeamId { get; set; }
        public int? PlayerId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Order { get; set; }
    }
}