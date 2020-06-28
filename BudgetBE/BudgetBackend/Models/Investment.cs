using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetBackend.Models
{
    public class Investment
    {
        public Guid Id { get; set; }

        public List<InvestmentHistory> InvestmentHistories { get; set; }

        public Guid portfolioId { get; set; }
        public Portfolio portfolio { get; set; }
    }
}
