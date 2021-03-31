using System;
using System.Collections.Generic;

namespace CricMazaServerDb.Models
{
    public partial class MatchList
    {
        public int Mid { get; set; }
        public string MatchList1 { get; set; }
        public DateTime Mdate { get; set; }
        public string Mtime { get; set; }
        public string Venue { get; set; }
    }
}
