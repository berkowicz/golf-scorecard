using golf_scorecard.Data;
using golf_scorecard.Server.Models;
using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;
        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<HolesViewModel> GetCourseData(int course)
        {
            try
            {

                HolesViewModel holesViewModels = new HolesViewModel();
                //List of holes
                List<HoleViewModel> listHoleViewModel = new List<HoleViewModel>();

                var holes = _context.Holes
                        .Where(x => x.CourseRefId == course).ToList();

                foreach (Hole hole in holes)
                {
                    HoleViewModel hvm = new HoleViewModel();
                    {
                        hvm.Id = hole.Id;
                        hvm.Number = hole.Number;
                        hvm.Par = hole.Par;
                        hvm.HoleIndex = hole.HoleIndex;
                    };
                    listHoleViewModel.Add(hvm);
                }

                holesViewModels.Holes = listHoleViewModel;

                if (holesViewModels == null)
                {
                    return await Task.FromResult<HolesViewModel>(null);
                }
                else
                    return await Task.FromResult(holesViewModels);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return null; // or other appropriate action
            }
        }
    }
}
