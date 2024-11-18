using CarRazor.MockData;
using CarRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRazor.Pages
{
    public class GetAllCarsModel : PageModel
    {
        public List<Car> Cars { get; set; }
        public void OnGet()
        {
            Cars = MockCars.GetCars();
        }
    }
}
