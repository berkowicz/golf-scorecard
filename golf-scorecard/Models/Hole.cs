using System.ComponentModel.DataAnnotations;

namespace golf_scorecard.Models
{
    public class Hole
    {
        [Key]
        public int Id { get; set; }
        public int Course { get; set; }
        public int Number { get; set; }
        public int Par { get; set; }
        public int Index { get; set; }
    }
}
