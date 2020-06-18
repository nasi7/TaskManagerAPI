using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerDAL.Models
{
    public class Quote
    {
        public int ID { get; set; }
        [Required]
        public string QuoteType { get; set; }
        [Required]
        public string Contact { get; set; }
        public string TaskDescription { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public string TaskType { get; set; }
    }
}



