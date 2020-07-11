using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BudgetBackend.Controllers
{
    [AllowAnonymous]
    [Route("[controller]/[action]")]
    [ApiController]
    public class InvestmentController : ControllerBase
    {
        private readonly ILogger _logger;

        public InvestmentController(ILogger<InvestmentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult CreateInvestment([FromBody] NewInvestment newInvestment)
        {
            using (var context = new UserContext())
            {
                var user = context.Users.Include(x => x.Portfolio).ToList().Find(x => x.Id == new Guid("CCB2EB11-FA37-426D-A545-43999A7FBDFA"));
                Investment investment = new Investment(newInvestment.type, newInvestment.amount);
                InvestmentHistory investmentHistory = new InvestmentHistory(DateTime.UtcNow, investment.Initial);

                if (user.Portfolio == null)
                {
                    Portfolio portfolio = new Portfolio();
                    user.Portfolio = portfolio;
                }

                investment.InvestmentHistories.Add(investmentHistory);
                user.Portfolio.Investments.Add(investment);
                context.SaveChanges();

            }

            return Ok();
        }

        [HttpGet]
        public IActionResult GetInvestments()
        {
            using (var context = new UserContext())
            {
                try
                {
                    var user = context.Users.Include(q => q.Portfolio).ThenInclude(q => q.Investments).ToList().Find(x => x.Id == new Guid("CCB2EB11-FA37-426D-A545-43999A7FBDFA"));

                    return Ok(user.Portfolio.Investments);
                }
                catch (Exception e)
                {
                    _logger.LogError($"Failed to get investments: {e}");
                    return BadRequest();
                }
            }


        }
        public class NewInvestment
        {
            public string type { get; set; }
            public int amount { get; set; }
        }
    }

}
