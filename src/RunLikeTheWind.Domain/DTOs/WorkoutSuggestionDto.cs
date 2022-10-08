
using RunLikeTheWind.Domain.Interfaces;

namespace RunLikeTheWind.Domain.DTOs
{
    [Serializable]
    public class WorkoutSuggestionDto
    {
        public readonly string SuggestedWorkout;
        public readonly IWeather Weather;
        public WorkoutSuggestionDto(string suggestedWorkout, IWeather weather)
        {
            SuggestedWorkout = suggestedWorkout;
            Weather = weather;
        }

        //TODO Use AutoMapper on Dtos and VM.
        public ViewModelWorkoutSuggestion ToViewModelWorkoutSuggestion()
        {
            return new ViewModelWorkoutSuggestion()
            {
                WorkoutSuggestion = SuggestedWorkout,
                TemperatureCelcius = Weather.TemperatureCelcius,
                WeatherIcon = Weather.WeatherIcon,
                WindDirection = Weather.WindDirection,
                WindSpeedKph = Weather.WindSpeedKph,
                LocalTime = Weather.LocalTime,
                Timezone = Weather.Timezone,
                Country = Weather.Country,
                Longitude = Weather.Longitude,
                Latitude = Weather.Latitude                            
            };
        }
    }
}
