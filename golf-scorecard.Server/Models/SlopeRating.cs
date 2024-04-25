using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace golf_scorecard.Server.Models
{
    public class SlopeRating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Info { get; set; }
        [Required]
        public float CR { get; set; }
        [Required]
        public float Slope { get; set; }
        [Required]
        public float ScratchValue { get; set; }


        [ForeignKey("Course")]
        public int CourseRefId { get; set; }
        [AllowNull]
        public virtual Course Course { get; set; }

        [ForeignKey("Gender")]
        public int GenderRefId { get; set; }
        [AllowNull]
        public virtual Gender Gender { get; set; }

        [ForeignKey("Tee")]
        public int TeeRefId { get; set; }
        [AllowNull]
        public virtual Tee Tee { get; set; }
    }
}
