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
    public class DetailsModel : PageModel
    {
        private readonly IRestaurantData iRestaurantData;
        public DetailsModel(IRestaurantData iRestaurantData)
        {
            this.iRestaurantData = iRestaurantData;
        }
       
        public Restaurant restaurant { get; set; }
       

        public void OnGet(int restaurantId)
        {
            restaurant = iRestaurantData.GetRestaurantOnId(restaurantId);
        }
    }
}
