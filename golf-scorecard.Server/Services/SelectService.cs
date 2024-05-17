using golf_scorecard.Data;
using golf_scorecard.Server.Models;
using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public class SelectService : ISelectService
    {
        private readonly ApplicationDbContext _context;
        public SelectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SlopeRating> GetDataByPublicIdAsync(int id)
        {
            var datax = _context.SlopeRatings
                .Where(x => x.Id == id)
                .FirstOrDefault();

            if (datax == null)
            {
                return await Task.FromResult<SlopeRating>(null);
            }

            return await Task.FromResult(datax);
        }

        public async Task<HomeViewModel> GetDataAsync()
        {
            var homeViewModel = new HomeViewModel
            {
                Courses = _context.Courses.ToList(),
                Tees = _context.Tees.ToList(),
                Genders = _context.Genders.ToList(),
            };

            Console.WriteLine($"count {homeViewModel.Genders.Count}");

            if (homeViewModel == null)
            {
                return await Task.FromResult<HomeViewModel>(null);
            }

            return await Task.FromResult(homeViewModel);
        }


        public async Task<StrokesViewModel> StartRound(NewGameDataViewModel newGameData)
        {
            try
            {
                var slopeRating = _context.SlopeRatings
                .Where(x => x.CourseRefId == newGameData.CourseId
                && x.TeeRefId == newGameData.TeeId
                && x.GenderRefId == newGameData.GenderId).FirstOrDefault();

                int strokes = CalculateStrokes(slopeRating, newGameData);

                var strokesViewModel = new StrokesViewModel
                {
                    Strokes = strokes,
                };



                //Console.WriteLine(Task.FromResult(createNewGameViewModel).Result);

                if (strokesViewModel == null)
                {
                    return await Task.FromResult<StrokesViewModel>(null);
                }
                else
                    return await Task.FromResult(strokesViewModel);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return null; // or other appropriate action
            }


        }
        public int CalculateStrokes(SlopeRating? sr, NewGameDataViewModel newGameData)
        {
            var course = _context.Courses.Where(x => x.Id == newGameData.CourseId).FirstOrDefault();
            float coursePar = course.Par;
            float floatHandicap = newGameData.Handicap;
            //exact handicap *(Slope / 113) + (CR - Course Par) = Number of strokes player aquires
            float strokes = floatHandicap * (sr.Slope / 113f) + (sr.CR - coursePar);
            int roundedStrokes = (int)Math.Floor(strokes);
            return roundedStrokes;
        }
    }
}
