using FirstDotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstDotnet.Data
{
    public interface IRestaurantData
    {
         IEnumerable<Restaurant> GetRestaurants();

          Restaurant GetRestaurantOnId(int RestaurantId);
    }

    public class RestaurantData : IRestaurantData
    {
        List<Restaurant> restaurantData = null;
        public RestaurantData()
        {
            restaurantData = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="Green Lands",Location="Hyderabad",cuisine=Cuisine.Indian },
                new Restaurant{Id=2,Name="Alfa cafe",Location="Secunderabad",cuisine=Cuisine.Mexican},
                new Restaurant{Id=3,Name="Viajaya Restaurant",Location="Eluru",cuisine=Cuisine.Italian}
            };

        }

        public Restaurant GetRestaurantOnId(int RestaurantId)
        {
            return restaurantData.FirstOrDefault(m => m.Id == RestaurantId);
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return restaurantData;
        }
    }
}
