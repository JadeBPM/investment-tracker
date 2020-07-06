using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetBackend.Models
{
    public class Investment
    {
        public Investment(string type, double initial)
        {
            Type = type;
            Initial = initial;
            Current = initial;

            InvestmentHistories = new List<InvestmentHistory>();
        }
        public Guid Id { get; set; }

        public List<InvestmentHistory> InvestmentHistories { get; set; }

        public Guid PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public string Type { get; set; }
        public double Current { get; set;  }
        public double Initial { get; set; }
    }
}
