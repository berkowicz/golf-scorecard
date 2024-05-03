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

        //public async Task<HomeViewModel> GetDataAsync()
        //{
        //    var homeViewModel = new HomeViewModel
        //    {
        //        Courses = _context.Courses.ToList(),
        //        Tees = _context.Tees.ToList(),
        //        Genders = _context.Genders.ToList(),
        //    };

        //    Console.WriteLine($"count {homeViewModel.Genders.Count}");

        //    if (homeViewModel == null)
        //    {
        //        return await Task.FromResult<HomeViewModel>(null);
        //    }

        //    return await Task.FromResult(homeViewModel);
        //}

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

        public HomeViewModel GetDataAsync3()
        {
            var homeViewModel = new HomeViewModel
            {
                Courses = _context.Courses.ToList(),
                Tees = _context.Tees.ToList(),
                Genders = _context.Genders.ToList(),
            };

            if (homeViewModel == null)
            {
                return (null);
            }

            return homeViewModel;
        }


    }
}
