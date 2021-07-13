using System.ComponentModel.DataAnnotations;

namespace GigHb.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        
        // need to verify is constraints where applied
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}