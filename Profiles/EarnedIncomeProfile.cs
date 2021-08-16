using AutoMapper;
using ChaosEmeraldsOfIncome.Controllers;
using ChaosEmeraldsOfIncome.Dtos;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Profiles
{
    public class EarnedIncomeProfile : Profile
    {
        public EarnedIncomeProfile()
        {
            // Source -> Target 
            CreateMap<EarnedIncome, EarnedIncomeReadDto>();
            CreateMap<EarnedIncomeCreateDto, EarnedIncome>();
        }
    }
}