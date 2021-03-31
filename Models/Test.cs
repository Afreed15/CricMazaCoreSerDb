using System;
using System.Collections.Generic;

namespace CricMazaServerDb.Models
{
    public partial class Test
    {
        public int Id { get; set; }
        public string Cname { get; set; }
        public string Email { get; set; }
        public string ProjectName { get; set; }
        public DateTime? Idate { get; set; }
    }
}
