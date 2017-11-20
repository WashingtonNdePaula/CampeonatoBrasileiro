using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public int AreaId { get; set; }
        public int VenueId { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool Active { get; set; }
        public string AreaName { get; set; }
        public string VenueName { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public int Founded { get; set; }
        public string ClubColor1 { get; set; }
        public string ClubColor2 { get; set; }
        public string ClubColor3 { get; set; }
        public string Nickname1 { get; set; }
        public string Nickname2 { get; set; }
        public string Nickname3 { get; set; }
        public string WikipediaLogoUrl { get; set; }
        public string WikipediaWordMarkUrl { get; set; }
        public int GlobalTeamId { get; set; }
        public IList<Player> Players { get; set; }
    }
}