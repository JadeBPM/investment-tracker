using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BudgetBackend.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class InvestmentController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateInvestment(int amount, string type)
        {
            return Accepted(amount);
        }

    }
}
