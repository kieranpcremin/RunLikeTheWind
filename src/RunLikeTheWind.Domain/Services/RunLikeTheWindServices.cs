using Microsoft.Extensions.Configuration;
using RunLikeTheWind.Domain.DTOs;
using RunLikeTheWind.Domain.Interfaces;
using RunLikeTheWind.Domain.WorkoutPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RunLikeTheWind.Domain.Services
{
    public class RunLikeTheWindServices : IRunLikeTheWindServices
    {

        public RunLikeTheWindServices()
        {

        }
        public async Task<WorkoutSuggestionDto> CreateTodaysWorkoutSuggestionAsync(IWeatherforecastService weatherforecastService, string city)
        {
            //No db. Shouldnt be accesing key from web api layer directly but as brief said no db
            //I'm assuming its ok to read api key from a congif and not have db layer with repository or fake repo.
            IWeather weather;

            weather = await weatherforecastService.GetWeatherForecastFromExternalApiAsync(city);
            string workoutPlan = WorkoutPlannerFactory.Create(weather).CreateWorkoutPlan();


            return new WorkoutSuggestionDto(workoutPlan, weather);
        }
    }
}
