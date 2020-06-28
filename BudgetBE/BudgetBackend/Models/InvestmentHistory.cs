using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetBackend.Models
{
    public class InvestmentHistory
    {
        public Guid Id { get; set; }
        public Guid InvestmentId { get; set; }
        public Investment investment { get; set; }

        
    }
}
