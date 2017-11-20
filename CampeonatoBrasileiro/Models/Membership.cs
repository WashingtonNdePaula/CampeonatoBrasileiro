using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public string TeamArea { get; set; }
        public bool Active { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Updated { get; set; }
    }
}