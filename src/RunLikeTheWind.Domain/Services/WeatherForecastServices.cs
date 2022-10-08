using Newtonsoft.Json;
using RunLikeTheWind.Domain.Interfaces;
using RunLikeTheWind.Domain.Weather;


namespace RunLikeTheWind.Domain.Services
{
    public class WeatherForecastServices : IWeatherforecastService
    {
        private readonly string apiKey;
        private readonly string apiUrl;
        public WeatherForecastServices(string externalApiKey, string url)
        {
            apiKey = externalApiKey;
            apiUrl = url;
        }
        public async Task<IWeather> GetWeatherForecastFromExternalApiAsync(string city)
        {

            var client = new HttpClient();
            IWeather weather = null;

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(apiUrl+city),
                Headers =
                {
                    { "X-RapidAPI-Key", apiKey },
                    { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Root root = JsonConvert.DeserializeObject<Root>(body);

                weather = new Weather.Weather(root.current.wind_dir, root.current.wind_kph,
                                                  root.current.temp_c, root.current.condition.icon)
                {
                    Country = root.location.country,
                    LocalTime = root.location.localtime,
                    Timezone = root.location.tz_id,
                    Longitude = root.location.lon,
                    Latitude = root.location.lat
                };
            }

            return weather;
        }
    }
}
