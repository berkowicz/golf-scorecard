using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace golf_scorecard.Server.Models
{
    public class SlopeRating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float CR { get; set; }
        [Required]
        public float Slope { get; set; }
        [Required]
        public float SchratchValue { get; set; }


        [ForeignKey("Course")]
        public int CourseRefId { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("Gender")]
        public int GenderRefId { get; set; }
        public virtual Gender Gender { get; set; }

        [ForeignKey("Tee")]
        public int TeeRefId { get; set; }
        public virtual Tee Tee { get; set; }
    }
}
