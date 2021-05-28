using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/earnedIncome")]
    public class EarnedIncomeController : ControllerBase
    {
        private readonly MockEarnedIncomeRepo _repo = new MockEarnedIncomeRepo();

        public EarnedIncomeController(MockEarnedIncomeRepo repo)
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