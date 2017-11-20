using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Referee
    {
        public int RefereeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortName { get; set; }
        public string Nacionality { get; set; }
    }
}