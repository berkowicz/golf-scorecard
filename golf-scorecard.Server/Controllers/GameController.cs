using golf_scorecard.Server.Models.ViewModels;
using golf_scorecard.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace golf_scorecard.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ISelectService _testService;

        public GameController(ISelectService testService)
        {
            _testService = testService;
        }

        //[HttpGet("test/{id}")]
        //public async Task<IActionResult> TestData(int id)
        //{
        //    // Return a userquiz by it's id
        //    var getdata = await _testService.GetDataByPublicIdAsync(id);

        //    //var hej = new Hole()
        //    //{
        //    //    Id = getdata.Id,
        //    //};

        //    return Ok(getdata);
        //}

        [HttpGet()]
        public async Task<IActionResult> GetDataAsync()
        {
            var getdata = await _testService.GetDataAsync();

            return Ok(getdata);
        }

        [HttpPost()]
        public async Task<IActionResult> StartRound(NewGameDataViewModel newGameData)
        {

            var x = await _testService.StartRound(newGameData);
            Console.WriteLine(x);

            return Ok(x);
        }

        //[HttpGet()]
        //public IActionResult GetDataAsync2()
        //{
        //    var getdata = _testService.GetDataAsync2();

        //    return Ok(new { getdata });
        //}

        //[HttpGet()]
        //public IActionResult GetDataAsync3()
        //{
        //    var getdata = _testService.GetDataAsync3();
        //    //HomeViewModel model = new HomeViewModel(getdata);

        //    var responseData = new
        //    {
        //        courses = getdata.Courses,
        //        genders = getdata.Genders,
        //        tees = getdata.Tees,
        //    };
        //    Console.WriteLine("Response Data: " + JsonConvert.SerializeObject(responseData)); // Log the response data
        //    return Json(responseData); // Return the response to the client


        //    //return Ok(new { getdata });
        //}


    }
}
