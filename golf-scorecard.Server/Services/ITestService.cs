using golf_scorecard.Server.Models;

namespace golf_scorecard.Server.Services
{
    public interface ITestService
    {
        Task<SlopeRating> GetDataByPublicIdAsync(int id);
    }
}
