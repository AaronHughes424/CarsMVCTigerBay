using API.Contracts;
using API.Models;

namespace API.Repositories
{
    public class CarRepository : ICarRepository
    {
        public List<Car> Cars { get; set; }

        public CarRepository()
        {
            Cars = new List<Car>()
            {
                new Car()
                {
                    Make = "Volkswagen",
                    Model = "Polo",
                    Colour = "Black",
                    Doors = 3
                },
                new Car()
                {
                    Make = "Volkswagen",
                    Model = "Golf",
                    Colour = "Blue",
                    Doors = 5
                },
                new Car()
                {
                    Make = "Audi",
                    Model = "RS5",
                    Colour = "Grey",
                    Doors = 5
                }
            };
        }

        public IEnumerable<Car> GetCars()
        {
            return Cars;
        }
    }
}