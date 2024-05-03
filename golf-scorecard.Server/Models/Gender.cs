using System.ComponentModel.DataAnnotations;

namespace golf_scorecard.Server.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
