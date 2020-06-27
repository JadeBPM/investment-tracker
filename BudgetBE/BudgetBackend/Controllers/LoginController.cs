using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBackend.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public HttpStatusCode GetLogin()
        {
            return HttpStatusCode.OK;
        }
        
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            using (var context = new BudgetContext())
            {
                var userExist = context.Users.FirstOrDefault(user => user.Email == username && user.Password == password);

                return Accepted(userExist?.Id);
            }
        }

        [HttpPost]
        public HttpStatusCode SignUp(string firstName, string username, string password)
        {
            using (var context = new BudgetContext())
            {
             
                var user = new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = firstName,
                    Email = username,
                    Password = password
                };
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    return HttpStatusCode.Accepted;

                }
                catch (Exception e) 
                {
                    return HttpStatusCode.BadRequest;
                }
                
            }
        }
    }
}