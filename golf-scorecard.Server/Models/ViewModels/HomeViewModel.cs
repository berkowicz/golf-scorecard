using System.Diagnostics.CodeAnalysis;

namespace golf_scorecard.Server.Models.ViewModels
{
    public class HomeViewModel
    {
        [AllowNull]
        public List<Course> Courses { get; set; }

        [AllowNull]
        public List<Gender> Genders { get; set; }

        [AllowNull]
        public List<Tee> Tees { get; set; }
    }
}
