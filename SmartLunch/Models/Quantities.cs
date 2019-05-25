using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Quantities
    {
        public int ID { get; set; }
        public int DishesID {get; set;}
        public DateTime Q_time { get; set; }
        public int Quantity { get; set; }

        public Dishes Dishes { get; set; }


    }
}
