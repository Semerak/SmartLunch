using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLunch.Models
{
    public class List
    {
        //[Key]
        public int ID { get; set; }
        public int DishesID { get; set; }
        //[Key]
        public int L_quantity { get; set; }

        public Dishes Dishes { get; set; }
        public ICollection<Orders> Orders { get; set; }

    }
}
