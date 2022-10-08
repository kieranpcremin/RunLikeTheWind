using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunLikeTheWind.Domain.Weather;

namespace RunLikeTheWind.Domain.Interfaces
{
    public interface IWeatherforecastService
    {
        Task<IWeather> GetWeatherForecastFromExternalApiAsync(string city);
    }
}
