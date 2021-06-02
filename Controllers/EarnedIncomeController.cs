using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/earnedIncome")]
    public class EarnedIncomeController : ControllerBase
    {
        // private readonly MockEarnedIncomeRepo _repo = new MockEarnedIncomeRepo();

        // public EarnedIncomeController(MockEarnedIncomeRepo repo)
        // {
        //     _repo = repo;
        // }

        [HttpGet]
        public ActionResult<EarnedIncome> GetEarnedIncome()
        {
            var earnedIncome = new List<EarnedIncome>
            {
                new EarnedIncome{ UserId=823, IncomeTitle="Carpenter", IncomeAmount=2000, Frequency="Annual", IsCurrent=true},
                new EarnedIncome{ UserId=823, IncomeTitle="Plumber", IncomeAmount=3000, Frequency="Annual", IsCurrent=true},
                new EarnedIncome{ UserId=823, IncomeTitle="Writer", IncomeAmount=2250, Frequency="Annual", IsCurrent=true}
            };

            return Ok(earnedIncome);
        }
    }
}