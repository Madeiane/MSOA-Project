using System;

namespace Sistem_Bancar.Models
{
    public class Transaction
    {
        public string Date { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }

        
        public Transaction(string date, string description, string amount, string status)
        {
            Date = date;
            Description = description;
            Amount = amount;
            Status = status;
        }
    }
}