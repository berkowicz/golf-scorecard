using golf_scorecard.Data;
using golf_scorecard.Server.Models;
using golf_scorecard.Server.Models.ViewModels;

namespace golf_scorecard.Server.Services
{
    public class SelectService : ISelectService
    {
        private readonly ApplicationDbContext _context;
        public SelectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SlopeRating> GetDataByPublicIdAsync(int id)
        {
            var datax = _context.SlopeRatings
                .Where(x => x.Id == id)
                .FirstOrDefault();

            if (datax == null)
            {
                return await Task.FromResult<SlopeRating>(null);
            }

            return await Task.FromResult(datax);
        }

        public async Task<HomeViewModel> GetDataAsync()
        {
            var homeViewModel = new HomeViewModel
            {
                Courses = _context.Courses.ToList(),
                Tees = _context.Tees.ToList(),
                Genders = _context.Genders.ToList(),
            };

            Console.WriteLine($"count {homeViewModel.Genders.Count}");

            if (homeViewModel == null)
            {
                return await Task.FromResult<HomeViewModel>(null);
            }

            return await Task.FromResult(homeViewModel);
        }


        public async Task<StrokesViewModel> StartRound(NewGameDataViewModel newGameData)
        {
            try
            {
                var slopeRating = _context.SlopeRatings
                .Where(x => x.CourseRefId == newGameData.CourseId
                && x.TeeRefId == newGameData.TeeId
                && x.GenderRefId == newGameData.GenderId).FirstOrDefault();

                int strokes = CalculateStrokes(slopeRating, newGameData);

                var strokesViewModel = new StrokesViewModel
                {
                    Strokes = strokes,
                };



                //Console.WriteLine(Task.FromResult(createNewGameViewModel).Result);

                if (strokesViewModel == null)
                {
                    return await Task.FromResult<StrokesViewModel>(null);
                }
                else
                    return await Task.FromResult(strokesViewModel);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return null; // or other appropriate action
            }


        }
        public int CalculateStrokes(SlopeRating? sr, NewGameDataViewModel newGameData)
        {
            var course = _context.Courses.Where(x => x.Id == newGameData.CourseId).FirstOrDefault();
            float coursePar = course.Par;
            float floatHandicap = newGameData.Handicap;
            //exact handicap *(Slope / 113) + (CR - Course Par) = Number of strokes player aquires
            float strokes = floatHandicap * (sr.Slope / 113f) + (sr.CR - coursePar);
            int roundedStrokes = (int)Math.Floor(strokes);
            return roundedStrokes;
        }

        //public async Task<string> StartRound(NewGameDataViewModel newGameData)
        //{
        //    try
        //    {
        //        var slopeRating = _context.SlopeRatings
        //        .Where(x => x.CourseRefId == newGameData.CourseId
        //        && x.TeeRefId == newGameData.TeeId
        //        && x.GenderRefId == newGameData.GenderId).FirstOrDefault();

        //        var holes = _context.Holes
        //            .Where(x => x.CourseRefId == newGameData.CourseId).ToList();

        //        int handicap = newGameData.Handicap;

        //        int strokes = CalculateStrokes(slopeRating, newGameData);

        //        var createNewGameViewModel = new CreateNewGameViewModel
        //        {
        //            Handicap = handicap,
        //            Strokes = strokes,
        //            Holes = holes,
        //        };



        //        // Serialize object with reference handling
        //        var options = new JsonSerializerOptions
        //        {
        //            ReferenceHandler = ReferenceHandler.Preserve
        //        };
        //        var jsonString = JsonSerializer.Serialize(createNewGameViewModel, options);



        //        //Console.WriteLine(Task.FromResult(createNewGameViewModel).Result);

        //        if (createNewGameViewModel == null)
        //        {
        //            return await Task.FromResult<string>(null);
        //        }
        //        else
        //            return await Task.FromResult(jsonString);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log or handle the exception
        //        return null; // or other appropriate action
        //    }


        //}

        //public List<HolesViewModel> GetHoles(int courseId)
        //{
        //    var holes = _context.Holes
        //            .Where(x => x.CourseRefId == courseId).ToList();

        //    List<HoleViewModel> holeViewModels = new List<HoleViewModel>();

        //    HoleViewModel hvm = new HoleViewModel();
        //    foreach (Hole x in holes)
        //    {
        //        hvm = new
        //        {
        //            hvm.Id = x.Id;
        //            hvm.Number = x.Number;
        //            hvm.Par = x.Par;
        //            hvm.HoleIndex = x.HoleIndex;
        //        }
        //        holeViewModels.Add(hvm);


        //    }

        //    return holeViewModels;
        //}




        //public async Task<CreateNewGameViewModel> StartRound(int handicap, int gender, int course, int tee)
        //{
        //    var slopeRating = _context.SlopeRatings
        //        .Where(x => x.CourseRefId == course
        //        && x.TeeRefId == tee
        //        && x.GenderRefId == gender).FirstOrDefault();

        //    var holes = _context.Holes
        //        .Where(x => x.CourseRefId == course).ToList();

        //    float hcp = handicap;

        //    int strokes = CalculateStrokes(slopeRating, handicap, gender, course, tee);

        //    var createNewGameViewModel = new CreateNewGameViewModel
        //    {
        //        Handicap = hcp,
        //        Strokes = strokes,
        //        Holes = holes,
        //    };

        //    if (createNewGameViewModel == null)
        //    {
        //        return await Task.FromResult<CreateNewGameViewModel>(null);
        //    }
        //    else
        //        return await Task.FromResult(createNewGameViewModel);
        //}

        //public int CalculateStrokes(SlopeRating? sr, int handicap, int gender, int course, int tee)
        //{
        //    var _course = _context.Courses.Where(x => x.Id == course).FirstOrDefault();
        //    float coursePar = _course.Par;
        //    //exact handicap *(Slope / 113) + (CR - Course Par) = Number of strokes player aquires
        //    float strokes = handicap * (sr.Slope / 113f) + (sr.CR - coursePar);
        //    int roundedStrokes = (int)Math.Floor(strokes);
        //    return roundedStrokes;
        //}



        //public HomeViewModel GetDataAsync2()
        //{
        //    var homeViewModel = new HomeViewModel
        //    {
        //        Courses = _context.Courses.ToList(),
        //        Tees = _context.Tees.ToList(),
        //        Genders = _context.Genders.ToList(),
        //    };

        //    if (homeViewModel == null)
        //    {
        //        return (null);
        //    }

        //    return homeViewModel;
        //}

        //public HomeViewModel GetDataAsync3()
        //{
        //    var homeViewModel = new HomeViewModel
        //    {
        //        Courses = _context.Courses.ToList(),
        //        Tees = _context.Tees.ToList(),
        //        Genders = _context.Genders.ToList(),
        //    };

        //    if (homeViewModel == null)
        //    {
        //        return (null);
        //    }

        //    return homeViewModel;
        //}


    }
}
