using HomeDepotWebApp.Models;
using System.Data.Entity;

namespace HomeDepotWebApp.Storage
{
    public class HomeDepotContext : DbContext
    {
        public HomeDepotContext() : base("name=HomeDepotConnectionString")
        {

        }

        public DbSet<Tool> Tools { get; set; }
    }
}