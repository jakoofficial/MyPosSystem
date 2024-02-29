using Microsoft.AspNetCore.Mvc;
using MyPosSystem.Interfaces;
using MyPosSystem.Models;

namespace MyPosSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public WeatherForecastController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Product> Get()
        {
            var products = _repository.Product.FindAll();
            return products;
        }
    }
}
