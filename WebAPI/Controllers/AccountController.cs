using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class AccountController : ControllerBase
    {
        private readonly IRepo repo;

        public AccountController(IRepo repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IEnumerable<Employee> Register()
        {
            var data = repo.GetDetails();
            return data;
        }

        [HttpPost]
        public ActionResult Register([FromBody] Employee model)
        {
            repo.AddEmployee(model);
            return Ok();
        }

    }
}
