using golf_scorecard.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace golf_scorecard.Server.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("test/{id}")]
        public async Task<IActionResult> TestData(int id)
        {
            // Return a userquiz by it's id
            var getdata = await _testService.GetDataByPublicIdAsync(id);

            //var hej = new Hole()
            //{
            //    Id = getdata.Id,
            //};

            return Ok(getdata);
        }
    }
}
