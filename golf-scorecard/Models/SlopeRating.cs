﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace golf_scorecard.Models
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
        public Course Course { get; set; }

        [ForeignKey("Gender")]
        public int GenderRefId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("Tee")]
        public int TeeRefId { get; set; }
        public Tee Tee { get; set; }
    }
}
