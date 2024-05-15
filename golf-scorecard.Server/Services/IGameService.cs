using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public interface IGameService
    {
        Task<HolesViewModel> GetCourseData(int course);
    }
}
