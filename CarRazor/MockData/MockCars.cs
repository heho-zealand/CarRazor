using CarRazor.Models;

namespace CarRazor.MockData
{
    public class MockCars
    {
        private static List<Car> _cars = new List<Car>()
        {
            new Car("Volvo", "V70", "ABC123", 150, 5),
            new Car("Saab", "95", "DEF456", 120, 5),
            new Car("Volkswagen", "Passat", "GHI789", 140, 5),
        };

        public static List<Car> GetCars()
        {
           return _cars; 
        }

        public static void AddCar(Car car)
        {
            _cars.Add(car);
        }
    }
}
