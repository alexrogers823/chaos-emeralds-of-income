using System;
using System.Collections.Generic;
using AutoMapper;
using ChaosEmeraldsOfIncome.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/earnedIncome")]
    public class EarnedIncomeController : ControllerBase
    {
        private readonly IEarnedIncomeRepo _repo;
        private readonly IMapper _mapper;

        public EarnedIncomeController(IEarnedIncomeRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EarnedIncomeReadDto>> GetEarnedIncome()
        {

            var earnedIncome = _repo.GetEarnedIncome();

            return Ok(_mapper.Map<IEnumerable<EarnedIncomeReadDto>>(earnedIncome));
        }

        [HttpGet("{id}", Name="GetEarnedIncomeById")]
        public ActionResult<EarnedIncomeReadDto> GetEarnedIncomeById(int id)
        {
            var earnedIncome = _repo.GetEarnedIncomeById(id);
            return Ok(_mapper.Map<EarnedIncomeReadDto>(earnedIncome));
        }

        [HttpPost]
        public ActionResult<EarnedIncome> InsertEarnedIncome(EarnedIncome income)
        {
            _repo.InsertEarnedIncome(income);
            _repo.SaveChanges();

            // return CreatedAtRoute(newIncome);
            return Ok();
        }
    }
}