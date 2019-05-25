using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Prices
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int DishesID { get; set; }
        public DateTime P_time { get; set; }

        public Dishes Dishes { get; set; }
    }
}
