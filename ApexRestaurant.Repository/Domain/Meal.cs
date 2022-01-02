using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Meal
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int StaffId { get; set; }

        public DateTime Date_Of_Meal { get; set; }

        public int Cost_Of_Meal { get; set; }

        public string Other_details { get; set; }

    }
}