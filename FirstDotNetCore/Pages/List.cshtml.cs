using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDotnet.Data;
using FirstDotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstDotNetCore.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRestaurantData iRestaurantData;

        public IEnumerable<Restaurant> restaurants;
        public void OnGet()
        {
            restaurants = iRestaurantData.GetRestaurants();
        }

        public ListModel(IRestaurantData iRestaurantData)
        {
            this.iRestaurantData = iRestaurantData;
        }
    }
}
