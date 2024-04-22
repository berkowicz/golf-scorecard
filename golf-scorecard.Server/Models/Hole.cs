using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace golf_scorecard.Server.Models
{
    public class Hole
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Course")]
        public int CourseRefId { get; set; }
        public virtual Course Course { get; set; }

        [Required]
        public int Number { get; set; }
        [Required]
        public int Par { get; set; }
        [Required]
        public int HoleIndex { get; set; }
    }
}
