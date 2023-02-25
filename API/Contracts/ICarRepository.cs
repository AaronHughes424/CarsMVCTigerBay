using API.Models;

namespace API.Contracts
{
    public interface ICarRepository
    {
        public IEnumerable<Car> GetCars();
        void AddCar(Car car);
    }
}