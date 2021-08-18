using ChaosEmeraldsOfIncome.Data;
using ChaosEmeraldsOfIncome.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/RoyaltyIncome")]
    public class RoyaltyIncomeController : ControllerBase
    {
        private readonly IRoyaltyIncomeRepo _repo;

        public RoyaltyIncomeController(IRoyaltyIncomeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<RoyaltyIncome> GetRoyaltyIncome()
        {
            var royaltyIncome = _repo.GetAllRoyaltyIncome();
            return Ok(royaltyIncome);
        }
    }
}