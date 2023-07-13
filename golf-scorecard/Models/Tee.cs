using System.ComponentModel.DataAnnotations;

namespace golf_scorecard.Models
{
    public class Tee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
