using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/CapitalGains")]
    public class CapitalGainsController : ControllerBase
    {
        private readonly ICapitalGainsRepo _repo;

        public CapitalGainsController(ICapitalGainsRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CapitalGains>> GetCapitalGains()
        {
            var capitalGains = _repo.GetAllCapitalGains();

            return Ok(capitalGains);
        }
    }
}