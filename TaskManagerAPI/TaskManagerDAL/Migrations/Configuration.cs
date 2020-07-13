namespace TaskManagerDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using TaskManagerDAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManagerDAL.Context.QuoteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskManagerDAL.Context.QuoteContext context)
        {

            context.Quotes.AddOrUpdate(q => q.Contact, new Quote { QuoteType = "CS-782", Contact = "Paul", DueDate = DateTime.Parse("2020-05-16T21:20:58Z"), TaskDescription = "Versatile next generation pricing structure", TaskType = "flexibility" });
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
