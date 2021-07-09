using System;

namespace Gig.Models
{
    public class Gig
    {
        public ApplicationUser Artist { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public Genre Genre { get; set; }
        
    }
}