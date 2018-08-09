using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using Entities;

namespace Services
{
    public class MyDataContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}