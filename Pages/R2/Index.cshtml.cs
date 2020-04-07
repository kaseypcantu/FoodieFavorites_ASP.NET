using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodieFavorites.Core;
using FoodieFavorites.Data;

namespace FoodieFavorites.Pages.R2
{
    public class IndexModel : PageModel
    {
        private readonly FoodieFavorites.Data.FoodieFavsDbContext _context;

        public IndexModel(FoodieFavorites.Data.FoodieFavsDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
