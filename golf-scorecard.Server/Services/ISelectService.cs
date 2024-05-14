using golf_scorecard.Server.Models;
using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public interface ISelectService
    {
        // /test/{id}
        Task<SlopeRating> GetDataByPublicIdAsync(int id);
        // /test
        Task<HomeViewModel> GetDataAsync();
        //HomeViewModel GetDataAsync2();
        //HomeViewModel GetDataAsync3();

        Task<SlopeRating> StartRound(NewGameDataViewModel newGameData);
    }
}
