using System;
using System.Collections.Generic;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Context
{
    class QuoteInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<QuoteContext>
    {
        protected override void Seed(QuoteContext context)
        {
            var quotes = new List<Quote>
            {
                new Quote{QuoteType = "DYR", Contact="Ashar", DueDate = DateTime.Now, TaskDescription="Create objects", TaskType="add functionality"},
                new Quote{QuoteType = "BF", Contact="Wini", DueDate = DateTime.Now, TaskDescription="fix 'not found resource' screen", TaskType="fix bug"},
                new Quote{QuoteType = "BF", Contact="Nasi", DueDate = DateTime.Now, TaskDescription="remove sensitive account information", TaskType="delete feature"},
                new Quote{QuoteType = "TFG", Contact="Nash", DueDate = DateTime.Now, TaskDescription="implement orders screen", TaskType="add feature"},
                new Quote{QuoteType = "LL", Contact="Preeti", DueDate = DateTime.Now, TaskDescription="create domain level sequence diagram", TaskType="documentation"}
            };

            quotes.ForEach(q => context.Quotes.Add(q));
            context.SaveChanges();
        }
    }
}
