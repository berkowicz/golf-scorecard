using System.ComponentModel.DataAnnotations;

namespace golf_scorecard.Server.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Hole>? Holes { get; set; }
        public ICollection<SlopeRating>? SlopeRatings { get; set; }
    }
}
