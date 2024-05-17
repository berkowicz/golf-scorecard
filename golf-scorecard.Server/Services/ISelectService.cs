using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public interface ISelectService
    {
        Task<HomeViewModel> GetDataAsync();

        Task<StrokesViewModel> StartRound(NewGameDataViewModel newGameData);
    }
}
