using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetBackend.Models
{
    public class Portfolio
    {
        public Portfolio()
        {
            Investments = new List<Investment>();
        }
        public Guid Id { get; set; }

        public List<Investment> Investments { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
