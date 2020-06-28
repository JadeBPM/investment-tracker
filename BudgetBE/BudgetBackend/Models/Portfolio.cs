using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetBackend.Models
{
    public class Portfolio
    {
        public Guid Id { get; set; }

        public List<Investment> investments { get; set; }

        public Guid UserId { get; set; }
        public User user { get; set; }
    }
}
