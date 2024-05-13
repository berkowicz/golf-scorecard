namespace golf_scorecard.Server.Models.ViewModels
{
    public class GameDataViewModel
    {
        public int Strokes { get; set; }
        public Course Course { get; set; }
        public List<Hole> Holes { get; set; }
    }
}
