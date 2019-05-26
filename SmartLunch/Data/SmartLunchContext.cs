using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartLunch.Models;

namespace SmartLunch.Data
{
    public class SmartLunchContext:DbContext
    {
        public SmartLunchContext(DbContextOptions<SmartLunchContext> options) : base(options)
        {

        }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Forms> Forms { get; set; }
        public DbSet<List> List { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Quantities> Quantities { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Types> Types { get; set; }

    }
}
