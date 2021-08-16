using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/BusinessIncome")]
    public class BusinessIncomeController : ControllerBase
    {
        private readonly IBusinessIncomeRepo _repo;

        public BusinessIncomeController(IBusinessIncomeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BusinessIncome>> GetAllBusinessIncome()
        {
            var businesses = _repo.GetAllBusinessIncome();
            return Ok(businesses);
        }
    }
}