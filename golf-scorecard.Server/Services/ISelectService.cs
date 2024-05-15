using golf_scorecard.Server.Models;
using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public interface ISelectService
    {
        // /test/{id}
        Task<SlopeRating> GetDataByPublicIdAsync(int id);

        // /Select Get
        Task<HomeViewModel> GetDataAsync();
        // /Select Put
        //Task<CreateNewGameViewModel> StartRound(NewGameDataViewModel newGameData);
        Task<StrokesViewModel> StartRound(NewGameDataViewModel newGameData);

        //Task<CreateNewGameViewModel> StartRound(int handicap, int gender, int course, int tee);
    }
}
