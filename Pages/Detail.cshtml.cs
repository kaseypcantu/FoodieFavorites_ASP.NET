using FoodieFavorites.Core;
using FoodieFavorites.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodieFavorites.Pages
{
    public class Detail : PageModel
    {
        private readonly IRestaurantData restaurantData;
        
        [TempData]
        public string Message { get; set; }
        public Restaurant Restaurant { get; set; }

        public Detail(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}