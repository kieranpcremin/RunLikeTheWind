using RunLikeTheWind.Domain.Interfaces;


namespace RunLikeTheWind.Domain.WorkoutPlanner
{
    public class WorkoutPlanner : IWorkoutPlanner
    {
        private IWeather weather;
        
        public WorkoutPlanner(IWeather weather)
        {
            this.weather = weather;
        }

        /// <summary>
        /// The Workout planner has only weather data to work with :(
        /// When we get millions of users :) :)  It will need to be extensible to work with data
        /// such as a users previous workouts, heart rates, goals etc.
        /// Workout planner will then be able to suggest the likes of rest day, tempo runs, weights etc.
        /// </summary>
        /// <param name="weather"></param>
        public string CreateWorkoutPlan()
        {
            if (weather.WindSpeedKph >= Constants.StrongWindKmph)
                return String.Format("Run a route that mainly heads {0}. Go break that PR.", weather.WindDirection);

            if (weather.TemperatureCelcius >= Constants.HighTemperatureCelcius)
                return String.Format("Very easy run only. Stay well hydrated");

            return "I suggest a 5K tempo run today";
        }
    }

}
