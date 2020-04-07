using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodieFavorites.Core
{
    public class Restaurant
    {
        [Required]
        public int Id { get; set; }
        
        [Required, StringLength(80)]
        public string Name { get; set; }
        
        [Required, StringLength(80)]
        public string Location { get; set; }
        
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
