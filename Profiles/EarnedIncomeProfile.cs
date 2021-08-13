using AutoMapper;
using ChaosEmeraldsOfIncome.Controllers;
using ChaosEmeraldsOfIncome.Dtos;

namespace ChaosEmeraldsOfIncome.Profiles
{
    public class EarnedIncomeProfile : Profile
    {
        public EarnedIncomeProfile()
        {
            // Source -> Target 
            CreateMap<EarnedIncome, EarnedIncomeReadDto>();
        }
    }
}