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

        [HttpPost]
        public ActionResult<EarnedIncome> InsertEarnedIncome(EarnedIncome income)
        {
            var newIncome = _repo.InsertEarnedIncome(income);
            _repo.SaveChanges();

            // return CreatedAtRoute(newIncome);
            return Ok(newIncome);
        }
    }
}