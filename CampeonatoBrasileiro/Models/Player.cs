using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommomName { get; set; }
        public string ShortName { get; set; }
        public string Position { get; set; }
        public string PositionCategory { get; set; }
        public int? Jersey { get; set; }
        public string Foot { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }
        public string Nacionality { get; set; }
        public string InjuryStatus { get; set; }
        public string InjuryBodyPart { get; set; }
        public string InjuryNotes { get; set; }
        public string InjuryStartDate { get; set; }
        public string Updated { get; set; }
        public string PhotoUrl { get; set; }
        public string RotoWirePlayer { get; set; }
    }
}