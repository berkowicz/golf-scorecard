
namespace golf_scorecard.Server.Models.ViewModels
{
    public class CreateNewGameViewModel
    {
        public int Handicap { get; set; }
        public int Strokes { get; set; }
        public List<Hole>? Holes { get; set; }
    }
}
