using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/DividendIncome")]
    public class DividendIncomeController : ControllerBase
    {
        private readonly IDividendIncomeRepo _repo;

        public DividendIncomeController(IDividendIncomeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DividendIncome>> GetDividendIncome()
        {
            var dividendIncome = _repo.GetDividendIncome();
            return Ok(dividendIncome);
        }
    }
}