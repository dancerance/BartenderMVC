using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderMVC.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public string orderContent { get; set; }
        public DateTime orderTime { get; set; }
        public bool isComplete { get; set; }
    }
    public class OrderDBContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}