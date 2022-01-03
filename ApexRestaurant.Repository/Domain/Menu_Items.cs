using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Menu_Items
    {
        public int Id { get; set; }
        
        public int Menu_Id { get; set; }

        public string Menu_Item_Name { get; set; }

        public string Other_details { get; set; }
    }
}