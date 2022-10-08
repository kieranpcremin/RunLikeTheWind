using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLikeTheWind.Domain.DTOs
{
    public class ViewModelWorkoutSuggestion
    {
        public string? WorkoutSuggestion { get; set; }
        public string? WeatherIcon { get; set; }
        public double TemperatureCelcius { get; set; }
        public string? WindDirection { get; set; }
        public double? WindSpeedKph { get; set; }
        public string? LocalTime { get; set; }
        public string? Timezone { get; set; }
        public string? Country { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
    }
}
