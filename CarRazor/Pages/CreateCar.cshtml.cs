using CarRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRazor.Pages
{
    public class CreateCarModel : PageModel
    {
        [BindProperty]
        public Car Car { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            MockData.MockCars.AddCar(Car);
            return RedirectToPage("GetAllCars");
        }
    }
}
