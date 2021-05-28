using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockEarnedIncomeRepo : IEarnedIncomeRepo
    {
        public IEnumerable<EarnedIncome> GetEarnedIncome()
        {
            var earnedIncome = new List<EarnedIncome>
            {
                new EarnedIncome{ UserId=823, IncomeTitle="Carpenter", IncomeAmount=2000, Frequency="Annual", IsCurrent=true}
            };

            return earnedIncome;
        }
    }
}