using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public int ClientsID { get; set; }
        public int TablesId { get; set; }
        public int ListID { get; set; }

        public Clients Clients { get; set; }
        public Tables Tables { get; set; }
        public List List { get; set; }
    }
}
