using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace golf_scorecard.Models
{
    public class Hole
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Course")]
        public int CourseRefId { get; set; }
        public Course Course { get; set; }

        [Required]
        public int Number { get; set; }
        [Required]
        public int Par { get; set; }
        [Required]
        public int Index { get; set; }
    }
}
