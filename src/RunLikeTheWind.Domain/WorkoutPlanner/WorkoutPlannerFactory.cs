using RunLikeTheWind.Domain.Interfaces;


namespace RunLikeTheWind.Domain.WorkoutPlanner
{
    internal static class WorkoutPlannerFactory
    {
        public static WorkoutPlanner Create(IWeather weather)
        {
            return new WorkoutPlanner(weather);
        }
    }
}
