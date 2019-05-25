using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Types
    {
        public int ID { get; set; }
        public string Name_type { get; set; }

        public ICollection<Dishes> Dishes { get; set; }
    }
}
