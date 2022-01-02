using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Menu
    {
        public int Id { get; set; }

        public string DishName { get; set; }

        public int Price { get; set; }

        public DateTime AvailableDateFrom { get; set; }

        public DateTime AvailableDateTo { get; set; }

        public string OtherDetails { get; set; }

        

    }
}