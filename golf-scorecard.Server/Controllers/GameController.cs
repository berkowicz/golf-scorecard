using golf_scorecard.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace golf_scorecard.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        //[HttpGet()]
        //public async Task<IActionResult> GetGameData()
        //{
        //    var getdata = await _gameService.GetGameData();

        //    return Ok(getdata);
        //}
    }
}
