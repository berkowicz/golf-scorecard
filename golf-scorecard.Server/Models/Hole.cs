using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace golf_scorecard.Server.Models
{
    public class Hole
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Course")]
        public int CourseRefId { get; set; }
        [AllowNull]
        public virtual Course Course { get; set; }

        [Required]
        public int Number { get; set; }
        [Required]
        public int Par { get; set; }
        [Required]
        public int HoleIndex { get; set; }
    }
}
