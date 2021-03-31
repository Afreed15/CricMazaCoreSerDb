using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CricMazaServerDb.Models
{
    public partial class Teams
    {
        public Teams()
        {
            MatchesTeam1Navigation = new HashSet<Matches>();
            MatchesTeam2Navigation = new HashSet<Matches>();
            PlayerProfile = new HashSet<PlayerProfile>();
            Players = new HashSet<Players>();
            PointsTable = new HashSet<PointsTable>();
        }

        public int Tid { get; set; }
        public string Tname { get; set; }
        public string Towner { get; set; }
        public string Teamlogo { get; set; }

        [NotMapped]
        [DisplayName("Upload Profile Pic")]
        public IFormFile PPicFile { get; set; }

        public virtual ICollection<Matches> MatchesTeam1Navigation { get; set; }
        public virtual ICollection<Matches> MatchesTeam2Navigation { get; set; }
        public virtual ICollection<PlayerProfile> PlayerProfile { get; set; }
        public virtual ICollection<Players> Players { get; set; }
        public virtual ICollection<PointsTable> PointsTable { get; set; }
    }
}
