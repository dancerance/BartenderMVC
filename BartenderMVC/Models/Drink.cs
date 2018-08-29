using System.Data.Entity;

namespace BartenderMVC.Models
{
    public class Drink
    {
        public int drinkID { get; set; }
        public string drinkName { get; set; }
        public string drinkDescription { get; set; }
        public double drinkPrice { get; set; }
    }
    
    public class DrinksDBContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
    }
}