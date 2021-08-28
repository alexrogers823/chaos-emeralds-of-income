using System;
using System.Collections.Generic;
using AutoMapper;
using ChaosEmeraldsOfIncome.Data;
using ChaosEmeraldsOfIncome.Dtos;
using ChaosEmeraldsOfIncome.Models;
using Microsoft.AspNetCore.JsonPatch;
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

        [HttpPatch("{id}")]
        public ActionResult UpdateEarnedIncome(int id, JsonPatchDocument<EarnedIncomeUpdateDto> patchDoc)
        {
            var incomeModel = _repo.GetEarnedIncomeById(id);
            if (incomeModel == null)
            {
                return NotFound();
            }

            var incomePatch = _mapper.Map<EarnedIncomeUpdateDto>(incomeModel);
            patchDoc.ApplyTo(incomePatch, ModelState);

            if (!TryValidateModel(incomePatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(incomePatch, incomeModel);
            _repo.UpdateEarnedIncome(incomeModel);
            _repo.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult ArchiveEarnedIncome(int id)
        {
            var incomeModel = _repo.GetEarnedIncomeById(id);

            if (incomeModel == null)
            {
                return NotFound();
            }

            var archived = _repo.ArchiveEarnedIncome(incomeModel);

            _mapper.Map(archived, incomeModel);
            _repo.UpdateEarnedIncome(incomeModel);
            _repo.SaveChanges();

            return NoContent();
        }
    }
}