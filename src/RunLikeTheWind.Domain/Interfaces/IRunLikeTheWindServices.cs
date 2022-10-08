using Microsoft.Extensions.Configuration;
using RunLikeTheWind.Domain.DTOs;


namespace RunLikeTheWind.Domain.Interfaces
{
    public interface IRunLikeTheWindServices
    {
        Task<WorkoutSuggestionDto> CreateTodaysWorkoutSuggestionAsync(IWeatherforecastService weatherforecastService, string city);
    }
}
