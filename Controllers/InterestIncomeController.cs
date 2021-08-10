using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/interestIncome")]
    public class InterestIncomeController : ControllerBase
    {
        private readonly IInterestIncomeRepo _repo;

        public InterestIncomeController(IInterestIncomeRepo repo)
        {
            _repo = repo;       
        }

        [HttpGet]
        public ActionResult<InterestIncome> GetInterestIncome()
        {
            var interestIncome = _repo.GetAllInterestIncome();

            return Ok(interestIncome);
        }

        [HttpGet("{id}", Name="GetInterestIncomeById")]
        public ActionResult<InterestIncome> GetInterestIncomeById(int id)
        {
            var interestIncome = _repo.GetInterestIncomeById(id);
            return Ok(interestIncome);
        }

        [HttpPost]
        public ActionResult<InterestIncome> AddInterestIncome(InterestIncome newIncome)
        {
            _repo.AddInterestIncome(newIncome);
            _repo.SaveChanges();
            return CreatedAtRoute(new {Id = 9}, newIncome);
        }

        [HttpPut]
        public ActionResult<InterestIncome> UpdateInterestIncome(InterestIncome incomeObj)
        {
            _repo.UpdateInterestIncome(incomeObj);
            _repo.SaveChanges();
            return Ok(incomeObj); //Change this to reflect updated income
        }
    }
}