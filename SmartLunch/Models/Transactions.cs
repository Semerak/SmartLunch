﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLunch.Models
{
    public class Transactions
    {
        public int ID { get; set; }
        public int ClientsID { get; set; }
        public DateTime T_time { get; set; }
        public decimal Balance { get; set; }
        public string Assignment { get; set; }

        public Clients Clients { get; set; }
    }
}
