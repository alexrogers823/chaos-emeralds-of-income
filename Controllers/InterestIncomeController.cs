using System.Collections.Generic;
using AutoMapper;
using ChaosEmeraldsOfIncome.Data;
using ChaosEmeraldsOfIncome.Dtos;
using ChaosEmeraldsOfIncome.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/interestIncome")]
    public class InterestIncomeController : ControllerBase
    {
        private readonly IInterestIncomeRepo _repo;
        private readonly IMapper _mapper;

        public InterestIncomeController(IInterestIncomeRepo repo, IMapper mapper)
        {
            _repo = repo;       
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<InterestIncomeReadDto>> GetInterestIncome()
        {
            var interestIncome = _repo.GetAllInterestIncome();

            return Ok(_mapper.Map<InterestIncomeReadDto>(interestIncome));
        }

        [HttpGet("{id}", Name="GetInterestIncomeById")]
        public ActionResult<InterestIncomeReadDto> GetInterestIncomeById(int id)
        {
            var interestIncome = _repo.GetInterestIncomeById(id);
            return Ok(_mapper.Map<InterestIncomeReadDto>(interestIncome));
        }

        [HttpPost]
        public ActionResult<InterestIncomeReadDto> AddInterestIncome(InterestIncomeCreateDto newIncomeCreateDto)
        {
            var incomeModel = _mapper.Map<InterestIncome>(newIncomeCreateDto);
            _repo.AddInterestIncome(incomeModel);
            _repo.SaveChanges();

            var incomeReadDto = _mapper.Map<InterestIncomeReadDto>(incomeModel);

            return CreatedAtRoute(nameof(GetInterestIncomeById), new {Id = incomeReadDto.Id}, incomeReadDto);
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