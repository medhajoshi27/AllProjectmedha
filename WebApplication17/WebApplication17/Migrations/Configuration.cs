namespace WebApplication17.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication17.Models.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication17.Models.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
             context.Persons.AddOrUpdate(
                  p => p.Name,
                  new Person { Name = "Andrew Peters" , Age=21, Email="andrew@exp.com" },
                  new Person { Name = "Brice Lambson" , Age = 20, Email = "brice@exp.com" },
                  new Person { Name = "Rowan Miller", Age = 22, Email = "rowan@exp.com" }
                );
            //
        }
    }
}
