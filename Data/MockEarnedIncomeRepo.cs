using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public class MockEarnedIncomeRepo : IEarnedIncomeRepo
    {
        public EarnedIncome ArchiveEarnedIncome(EarnedIncome income)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EarnedIncome> GetEarnedIncome()
        {
            var earnedIncome = new List<EarnedIncome>
            {
                new EarnedIncome{ UserId=823, IncomeTitle="Carpenter", IncomeAmount=2000, Frequency="Annual", IsCurrent=true},
                new EarnedIncome{ UserId=823, IncomeTitle="Plumber", IncomeAmount=3000, Frequency="Annual", IsCurrent=true},
                new EarnedIncome{ UserId=823, IncomeTitle="Writer", IncomeAmount=2250, Frequency="Annual", IsCurrent=true}
            };

            return earnedIncome;
        }

        public EarnedIncome GetEarnedIncomeById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void InsertEarnedIncome(EarnedIncome income)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateEarnedIncome(EarnedIncome income)
        {
            throw new System.NotImplementedException();
        }
    }
}