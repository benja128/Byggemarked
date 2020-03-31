namespace HomeDepotWebApp.Migrations
{
    using HomeDepotWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeDepotWebApp.Storage.HomeDepotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HomeDepotWebApp.Storage.HomeDepotContext context)
        {
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 1, Name = "Kultivator", Description = "River jorden op", Depos = 100, DayPrice = 50 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 2, Name = "Motersav", Description = "Nem og kraftfuld maskine", Depos = 75, DayPrice = 25 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 3, Name = "Slagboremaskine", Description = "Kan bore igennem hvad som helst", Depos = 50, DayPrice = 40 });
            context.Tools.AddOrUpdate(t => t.Name, new Tool { Id = 4, Name = "Græsslåmaskine", Description = "Slår græsset hurtigere end en veganer kan spise det", Depos = 125, DayPrice = 150 });

            context.Customers.AddOrUpdate(c => c.Name, new Customer { CustomerId = 001, Name = "John Doe", Email = "JD@live.dk", Username = "JohnD", Password = "123" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
