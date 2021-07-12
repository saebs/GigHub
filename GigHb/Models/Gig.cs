using System;
using System.ComponentModel.DataAnnotations;

namespace GigHb.Models
{
    public class Gig
    {
        public int Id { get; set; }
        
        [Required]
        public ApplicationUser Artist { get; set; }
        
        public DateTime Date { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Venue { get; set; }
        
        [Required]
        public Genre Genre { get; set; }
    }
}