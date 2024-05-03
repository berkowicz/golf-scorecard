using golf_scorecard.Server.Models;
using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public interface ITestService
    {
        // /test/{id}
        Task<SlopeRating> GetDataByPublicIdAsync(int id);
        // /test
        //Task<HomeViewModel> GetDataAsync();
        //HomeViewModel GetDataAsync2();
        HomeViewModel GetDataAsync3();
    }
}
