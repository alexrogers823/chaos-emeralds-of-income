using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("[EarnedIncome]")]
    public class EarnedIncomeController : ControllerBase
    {
        public EarnedIncomeController(IEarnedIncomeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<EarnedIncome> GetEarnedIncome()
        {
            var earnedIncome = _repo.GetEarnedIncome();
            
            return Ok(earnedIncome);
        }
    }
}