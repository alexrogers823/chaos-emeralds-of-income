using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/interestIncome")]
    public class InterestIncomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<InterestIncome> GetInterestIncome()
        {
            var interestIncome = new List<InterestIncome>
            {
                new InterestIncome{UserId=823, Name="Wells Fargo", InterestPercent=0.075, InterestDollar=5.75},
                new InterestIncome{UserId=823, Name="Discover", InterestPercent=0.055, InterestDollar=10.75},
                new InterestIncome{UserId=823, Name="Capital One", InterestPercent=0.080, InterestDollar=6.50}
            };

            return Ok(interestIncome);
        }
    }
}