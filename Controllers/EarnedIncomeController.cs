using System;
using System.Collections.Generic;
using AutoMapper;
using ChaosEmeraldsOfIncome.Dtos;
using ChaosEmeraldsOfIncome.Models;
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

            if (earnedIncome == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<EarnedIncomeReadDto>(earnedIncome));
        }

        [HttpPost]
        public ActionResult<EarnedIncomeReadDto> InsertEarnedIncome(EarnedIncomeCreateDto incomeCreateDto)
        {
            var incomeModel = _mapper.Map<EarnedIncome>(incomeCreateDto);
            _repo.InsertEarnedIncome(incomeModel);
            _repo.SaveChanges();

            var incomeReadDto = _mapper.Map<EarnedIncomeReadDto>(incomeModel);

            return CreatedAtRoute(nameof(GetEarnedIncomeById), new {Id = incomeReadDto.Id}, incomeReadDto);
        }
    }
}