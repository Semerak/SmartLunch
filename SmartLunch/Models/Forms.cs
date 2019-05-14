using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Forms
    {

        public int ID { get; set; }
        public string name_from { get; set; }

        public ICollection<Clients> Clients { get; set; }
    }
}
