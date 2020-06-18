using System;
using TaskManagerDAL.Context;
using TaskManagerDAL.Models;

namespace TaskManagerRepo
{
    public class UnitOfWork : IDisposable
    {
        private QuoteContext context = new QuoteContext();
        private Repository<Quote> quoteRepository;

        public Repository<Quote> QuoteRepository
        {
            get
            {

                if (this.quoteRepository == null)
                {
                    this.quoteRepository = new QuoteRepository(context);
                }
                return quoteRepository;
            }
        }


        public void Complete()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
