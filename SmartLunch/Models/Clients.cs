using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Clients
    {
        public int ID { get; set; }
       // public int c_id_client { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string father_name { get; set; }
        public int FormsID { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string code { get; set; }

        public Forms Forms { get; set; }
    }
}
 