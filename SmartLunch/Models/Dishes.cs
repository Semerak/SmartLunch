using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Dishes
    {
        public int ID { get; set; }
        public string Name_dish { get; set;}
        public int TypesID { get; set; }
        public string description { get; set; }

        public Types Types { get; set; }
        public ICollection<Quantities> Quantities { get; set; }
        public ICollection<Prices> Prices { get; set; }
        public ICollection<List> List { get; set; }
    }
}
