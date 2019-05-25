using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Tables
    { 
        public int ID { get; set; }
        public string Name_table { get; set; }
        public int Capacity { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
