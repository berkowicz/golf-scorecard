using golf_scorecard.Server.Models.ViewModels;
using golf_scorecard.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace golf_scorecard.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ISelectService _selectService;

        public SelectController(ISelectService selectService)
        {
            _selectService = selectService;
        }

        //Get data to select game options
        [HttpGet()]
        public async Task<IActionResult> GetDataAsync()
        {
            var getdata = await _selectService.GetDataAsync();

            return Ok(getdata);
        }

        [HttpPost("{tee}/{course}/{gender}/{handicap}")]
        public async Task<IActionResult> StartRound(int tee, int course, int gender, int handicap)
        {
            NewGameDataViewModel newGameData = new NewGameDataViewModel
            {
                Handicap = handicap,
                CourseId = course,
                TeeId = tee,
                GenderId = gender,
            };

            Console.WriteLine(newGameData.Handicap);
            Console.WriteLine(newGameData.GenderId);
            Console.WriteLine(newGameData.CourseId);
            Console.WriteLine(newGameData.TeeId);

            var strokes = await _selectService.StartRound(newGameData);

            return Ok(strokes);

        }

        ////Creates new game and returns data with guid for game
        //[HttpPost()]
        //public async Task<IActionResult> StartRound(NewGameDataViewModel newGameData)
        //{

        //    var createNewGame = await _selectService.StartRound(newGameData);
        //    Console.WriteLine(createNewGame.Strokes);

        //    return Ok(createNewGame);
        //}

        //Creates new game and returns data with guid for game
        //[HttpPost("{tee}/{course}/{gender}/{handicap}")]
        //public async Task<IActionResult> StartRound(int tee, int course, int gender, int handicap)
        //{
        //    NewGameDataViewModel newGameData = new NewGameDataViewModel
        //    {
        //        Handicap = handicap,
        //        CourseId = course,
        //        TeeId = tee,
        //        GenderId = gender,
        //    };

        //    Console.WriteLine(newGameData.Handicap);
        //    Console.WriteLine(newGameData.GenderId);
        //    Console.WriteLine(newGameData.CourseId);
        //    Console.WriteLine(newGameData.TeeId);

        //    var strokes = await _selectService.StartRound(newGameData);

        //    return Ok(strokes);

        //}

        //[HttpPost()]
        //public async Task<IActionResult> StartRound([FromBody] List<int> submitData)
        //{
        //    NewGameDataViewModel newGameData = new NewGameDataViewModel
        //    {
        //        TeeId = submitData[0],
        //        CourseId = submitData[1],
        //        GenderId = submitData[2],
        //        Handicap = submitData[3]
        //    };

        //    Console.WriteLine(newGameData.Handicap);
        //    Console.WriteLine(newGameData.GenderId);
        //    Console.WriteLine(newGameData.CourseId);
        //    Console.WriteLine(newGameData.TeeId);
        //    var createNewGame = await _selectService.StartRound(newGameData);
        //    return Ok(createNewGame);

        //}






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
