using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Context
{
    public class QuoteContext : DbContext
    {
        public QuoteContext() : base("QuoteContext")
        {
        }

        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
