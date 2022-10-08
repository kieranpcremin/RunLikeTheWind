using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLikeTheWind.Domain.Interfaces
{
    public interface IWeather
    {
        string WindDirection { get; }
        double WindSpeedKph { get; }
        string WeatherIcon { get; }
        double TemperatureCelcius { get; }

        //Following properties shoudl be extracted out to another interface and type. They dont belong in IWeather
        string LocalTime { get; }
        string Country { get; }
        double Longitude { get; }
        double Latitude { get; }
        string Timezone { get; }

    }
}
