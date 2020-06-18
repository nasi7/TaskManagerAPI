using TaskManagerDAL.Context;
using TaskManagerDAL.Models;

namespace TaskManagerRepo
{
    class QuoteRepository : Repository<Quote>
    {
        public QuoteRepository(QuoteContext context) : base(context)
        {
        }
    }
}
