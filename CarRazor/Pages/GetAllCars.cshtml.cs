using CarRazor.MockData;
using CarRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRazor.Pages
{
    public class GetAllCarsModel : PageModel
    {

        public List<Car> Cars { get; set; }

        private Services.CarService _carService;


        public GetAllCarsModel(Services.CarService carService)
        {
            _carService = carService;
        }
        public void OnGet()
        {
            Cars = _carService.GetCars();
        }
    }
}
