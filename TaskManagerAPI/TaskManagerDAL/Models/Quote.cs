using System;

namespace TaskManagerDAL.Models
{
    class Quote
    {
        public int QuoteID { get; set; }
        public string QuoteType { get; set; }
        public string Contact { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public string TaskType { get; set; }
    }
}
