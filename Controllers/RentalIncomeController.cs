using ChaosEmeraldsOfIncome.Data;
using ChaosEmeraldsOfIncome.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/RentalIncome")]
    public class RentalIncomeController : ControllerBase
    {
        private readonly IRentalIncomeRepo _repo;

        public RentalIncomeController(IRentalIncomeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<RentalIncome> GetRentalIncome()
        {
            var rentalIncome = _repo.GetAllRentalProperties();
            return Ok(rentalIncome);
        }
    }
}