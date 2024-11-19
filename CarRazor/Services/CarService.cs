using CarRazor.Models;

namespace CarRazor.Services
{
    public class CarService
    {
        private List<Car> _cars;

        public CarService()
        {
            _cars = MockData.MockCars.GetCars();
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }
    }
}
