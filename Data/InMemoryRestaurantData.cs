using System.Collections.Generic;
using System.Linq;
using FoodieFavorites.Core;

namespace FoodieFavorites.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Kasey's Wagyu Emporium", Location = "Austin, Texas", Cuisine = CuisineType.American },
                new Restaurant { Id = 2, Name = "Comida de Alexis", Location = "Austin, Texas", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Apollo's Burgers", Location = "Houston, Texas", Cuisine = CuisineType.American },
                new Restaurant { Id = 4, Name = "Zeus' Kolache House", Location = "Houston, Texas", Cuisine = CuisineType.American },
                new Restaurant { Id = 5, Name = "Bonsai Ben's Fortune", Location = "Houston, Texas", Cuisine = CuisineType.Asian },
                new Restaurant { Id = 6, Name = "Goku's Bento Shop", Location = "Earth", Cuisine = CuisineType.Asian },
                new Restaurant { Id = 7, Name = "Bulma Di Canizzaro", Location = "Earth", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 8, Name = "Vegeta Vegan Potstickers", Location = "Planet Vegeta", Cuisine = CuisineType.Asian },
                new Restaurant { Id = 9, Name = "Brooke's Rockin Cocina", Location = "The Grandline", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 10, Name = "French Franky's Robo Cafe", Location = "The Grandline", Cuisine = CuisineType.Cajun },
                new Restaurant { Id = 11, Name = "Chopper's Siesta Room", Location = "The Grandline", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 12, Name = "Cafe Hunan Nico", Location = "The Grandline", Cuisine = CuisineType.Asian },
                new Restaurant { Id = 13, Name = "Zoro's Master Sushi", Location = "The Grandline", Cuisine = CuisineType.Asian },
                new Restaurant { Id = 14, Name = "Beerus' Tandoori Grill", Location = "Berrus' Planet", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 15, Name = "Luffy's Takoyaki", Location = "The Grandline", Cuisine = CuisineType.Asian },
                new Restaurant { Id = 16, Name = "Whis Parmagiano Cart", Location = "Beerus' Planet", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 17, Name = "The Baratie feat. Sanji", Location = "The Grandline", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 18, Name = "Del Frisco's ownded by Bruce Wayne", Location = "Gotham, NewYork", Cuisine = CuisineType.American },
                new Restaurant { Id = 19, Name = "Jimbei's Tempura Shrimp", Location = "The Grandline", Cuisine = CuisineType.Asian },
                new Restaurant { Id = 20, Name = "Nami's Showoff's", Location = "The Grandline", Cuisine = CuisineType.American }
            };
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }

            return restaurant;
        }

        public int GetCountOfRestaurants()
        {
            return restaurants.Count();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name = null)
        {
            return from r in restaurants
                where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                orderby r.Name
                select r;
        }
    }
}