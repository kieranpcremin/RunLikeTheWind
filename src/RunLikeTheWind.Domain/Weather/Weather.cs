

using RunLikeTheWind.Domain.Interfaces;

namespace RunLikeTheWind.Domain.Weather
{
    public class Weather : IWeather
    {
        public string WindDirection { get; }
        public double WindSpeedKph { get; }
        public string WeatherIcon { get; }
        public double TemperatureCelcius { get; }

 
        //Following properties shoudl be extracted out to another interface and type. They dont belong in IWeather
        public string LocalTime { get; set; }
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Timezone { get; set; }

        private Dictionary<string, string> windDirectionDictionary = new Dictionary<string, string>();    

        public Weather(string windDirection, double windSpeed, double temperature, string weatherIcon)
        {
            PopulateWindDirections();

            this.WindDirection = windDirectionDictionary[windDirection];
            this.WindSpeedKph = windSpeed;
            this.TemperatureCelcius = temperature;
            this.WeatherIcon = weatherIcon;
        }

        private void PopulateWindDirections()
        {
            windDirectionDictionary.Add("N", "North");
            windDirectionDictionary.Add("NNE", "North East");
            windDirectionDictionary.Add("NE", "North East");
            windDirectionDictionary.Add("ENE", "North East");
            windDirectionDictionary.Add("E", "East");
            windDirectionDictionary.Add("ESE", "South East");
            windDirectionDictionary.Add("SE", "South East");
            windDirectionDictionary.Add("SSE", "South East");
            windDirectionDictionary.Add("S", "South");
            windDirectionDictionary.Add("SSW", "South West");
            windDirectionDictionary.Add("SW", "South West");
            windDirectionDictionary.Add("WSW", "South West");
            windDirectionDictionary.Add("W", "West");
            windDirectionDictionary.Add("WNW", "North West");
            windDirectionDictionary.Add("NW", "North West");
            windDirectionDictionary.Add("NNW", "North West");
        }
    }
}
