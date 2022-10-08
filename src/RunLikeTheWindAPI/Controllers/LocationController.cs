using Microsoft.AspNetCore.Mvc;
using RunLikeTheWindAPI.DTOs;

namespace RunLikeTheWindAPI.Controllers
{
    [ApiController]
    [Route("/location")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> logger;
        private readonly IConfiguration configuration;
        public LocationController(ILogger<LocationController> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }

        [HttpGet(Name = "GetCities")]
        public IEnumerable<City> Get()
        {
            return configuration.GetSection("Cities").Get<List<City>>();
        }
    }
}
