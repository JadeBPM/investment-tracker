using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetBackend.Models
{
    public class InvestmentHistory
    {
        public InvestmentHistory(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }
        public Guid Id { get; set; }
        public Guid InvestmentId { get; set; }
        public Investment Investment { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        
    }
}
