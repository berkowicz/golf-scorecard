using golf_scorecard.Data;
using golf_scorecard.Server.Models;
using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public class TestService : ITestService
    {
        private readonly ApplicationDbContext _context;
        public TestService(ApplicationDbContext context)
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


        public async Task<SlopeRating> StartRound(NewGameDataViewModel newGameData)
        {
            var data = _context.SlopeRatings
                .Where(x => x.CourseRefId == newGameData.CourseId
                && x.TeeRefId == newGameData.TeeId
                && x.GenderRefId == newGameData.GenderId).FirstOrDefault();

            //int strokes = CalculateStrokes(data, newGameData);

            if (data == null)
            {
                return await Task.FromResult<SlopeRating>(null);
            }

            return await Task.FromResult(data);
        }


        public int CalculateStrokes(SlopeRating? sr, NewGameDataViewModel newGameData)
        {
            var course = _context.Courses.Where(x => x.Id == newGameData.CourseId).FirstOrDefault();
            float coursePar = course.Par;
            //exact handicap *(Slope / 113) + (CR - Course Par) = Number of strokes player aquires
            float strokes = newGameData.Handicap * (sr.Slope / 113f) + (sr.CR - coursePar);
            int roundedStrokes = (int)Math.Floor(strokes);
            return roundedStrokes;
        }


        //public HomeViewModel GetDataAsync2()
        //{
        //    var homeViewModel = new HomeViewModel
        //    {
        //        Courses = _context.Courses.ToList(),
        //        Tees = _context.Tees.ToList(),
        //        Genders = _context.Genders.ToList(),
        //    };

        //    if (homeViewModel == null)
        //    {
        //        return (null);
        //    }

        //    return homeViewModel;
        //}

        //public HomeViewModel GetDataAsync3()
        //{
        //    var homeViewModel = new HomeViewModel
        //    {
        //        Courses = _context.Courses.ToList(),
        //        Tees = _context.Tees.ToList(),
        //        Genders = _context.Genders.ToList(),
        //    };

        //    if (homeViewModel == null)
        //    {
        //        return (null);
        //    }

        //    return homeViewModel;
        //}


    }
}
