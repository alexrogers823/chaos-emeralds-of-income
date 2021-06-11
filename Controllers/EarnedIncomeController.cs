using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/earnedIncome")]
    public class EarnedIncomeController : ControllerBase
    {
        private readonly IEarnedIncomeRepo _repo;

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

        // [HttpPost]
        // public ActionResult<EarnedIncome> InsertEarnedIncome()
        // {
        //     var newIncome = _repo.InsertEarnedIncome();

        //     return CreatedAtRoute(newIncome);
        // }
    }
}