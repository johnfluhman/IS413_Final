using System;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Quotes
    {
        [Key, Required]
        public int QuoteID { get; set; }
        [Required]
        public string Quote { get; set; }
        [Required]
        public string Author { get; set; }
        public int Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }
    }
}
