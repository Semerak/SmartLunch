using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLunch.Models
{
    public class Clients
    {
        public int ID { get; set; }
        public string Last_name { get; set; }
        public string First_name { get; set; }
        public string Father_name { get; set; }
        public int FormsID { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Code { get; set; }

        public Forms Forms { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
 