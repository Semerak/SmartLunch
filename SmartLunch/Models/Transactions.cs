using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLunch.Models
{
    public class Transactions
    {
        public int id_tr { get; set; }
        public int t_id_client { get; set; }
        public DateTime t_time { get; set; }
        public decimal balance { get; set; }
        public string assignment { get; set; }

        //public Clients Client { get; set; }
    }
}
