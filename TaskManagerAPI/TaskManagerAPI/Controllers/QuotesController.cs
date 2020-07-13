using System.Collections.Generic;
using System.Web.Http;
using TaskManagerDAL.Models;
using TaskManagerRepo;

namespace TaskManagerAPI.Controllers
{

    public class QuotesController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET api/quotes
        [Authorize]
        public IEnumerable<Quote> Get()
        {
            return unitOfWork.QuoteRepository.GetAll();
        }

        // GET api/quotes/5
        public Quote Get(int id)
        {

            return unitOfWork.QuoteRepository.Get(id);
        }

        // POST api/quotes
        public void Post([FromBody]Quote quote)
        {
            unitOfWork.QuoteRepository.Add(quote);
            unitOfWork.Complete();
        }

        // PUT api/quotes/5
        public void Put(int id, [FromBody]Quote newQuote)
        {
            /*unitOfWork.QuoteRepository.Delete(id);
            newQuote.ID = id;
            unitOfWork.QuoteRepository.Add(newQuote);*/
            Quote oldQuote = unitOfWork.QuoteRepository.Get(id);
            oldQuote.QuoteType = newQuote.QuoteType;
            oldQuote.TaskDescription = newQuote.TaskDescription;
            oldQuote.TaskType = newQuote.TaskType;
            oldQuote.Contact = newQuote.Contact;
            oldQuote.DueDate = newQuote.DueDate;
            unitOfWork.Complete();
        }

        // DELETE api/quotes/5
        public void Delete(int id)
        {
            unitOfWork.QuoteRepository.Delete(id);
            unitOfWork.Complete();
        }
    }
}
