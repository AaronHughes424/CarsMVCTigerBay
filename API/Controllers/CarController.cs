using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        [Route("cars")]
        public IEnumerable<Car> GetCars()
        {
            return _carRepository.GetCars();
        }

        [HttpPost]
        [Route("AddCar")]
        public IActionResult AddCar([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest();
            }

            _carRepository.AddCar(car);
            return Ok();
        }
    }
}