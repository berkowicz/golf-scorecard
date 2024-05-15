using System.ComponentModel.DataAnnotations;

namespace golf_scorecard.Server.Models.ViewModels
{
    public class HoleViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Par { get; set; }
        [Required]
        public int HoleIndex { get; set; }
    }
}
