using golf_scorecard.Data;
using golf_scorecard.Server.Models;

namespace golf_scorecard.Server.Services
{
    public class TestService : ITestService
    {
        private readonly ApplicationDbContext _context;
        public TestService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<SlopeRating> GetDataByPublicIdAsync(int id)
        {
            var datax = _context.SlopeRatings
                .Where(x => x.Id == id)
                .FirstOrDefault();

            if (datax == null)
            {
                return Task.FromResult<SlopeRating>(null);
            }

            return Task.FromResult(datax);
        }

    }
}
