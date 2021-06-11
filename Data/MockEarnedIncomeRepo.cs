using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockEarnedIncomeRepo : IEarnedIncomeRepo
    {
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

        public EarnedIncome InsertEarnedIncome(EarnedIncome income)
        {
            throw new System.NotImplementedException();
        }
    }
}