using System;

namespace FirstDotnet.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public Cuisine cuisine { get; set; }
    }


}
