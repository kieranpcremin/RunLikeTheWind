using Microsoft.AspNetCore.Mvc;
using RunLikeTheWind.Domain.DTOs;
using RunLikeTheWind.Domain.Interfaces;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace RunLikeTheWind.API.Controllers
{
    [ApiController]
    [Route("/workoutplanner")]
    public class WorkoutplannerController : ControllerBase
    {
        private readonly ILogger<WorkoutplannerController> logger;
        private readonly IRunLikeTheWindServices runLikeTheWindServices;
        private readonly IWeatherforecastService weatherforecastService;

        public WorkoutplannerController(ILogger<WorkoutplannerController> logger, 
                                        IRunLikeTheWindServices runLikeTheWindServices,
                                        IWeatherforecastService weatherforecastService)
        {
            this.logger = logger;
            this.runLikeTheWindServices = runLikeTheWindServices;
            this.weatherforecastService = weatherforecastService;
        }

        [HttpGet(Name = "GetWorkout")]
        public ActionResult<ViewModelWorkoutSuggestion> Get(string city)
        {
            var workoutSuggestion = runLikeTheWindServices.CreateTodaysWorkoutSuggestionAsync(weatherforecastService, city).Result;

            return workoutSuggestion.ToViewModelWorkoutSuggestion();
        }
    }
}
