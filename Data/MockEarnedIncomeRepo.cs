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

        // public EarnedIncome InsertEarnedIncome(EarnedIncome income)
        public IEnumerable<EarnedIncome> InsertEarnedIncome(EarnedIncome income) // temporary
        {
            if (income == null)
            {
                throw new System.NotImplementedException();
            }

            // _context.EarnedIncome.Add(income);
            var newEarnedIncome = new List<EarnedIncome>
            {
                new EarnedIncome{ UserId=823, IncomeTitle="Carpenter", IncomeAmount=2000, Frequency="Annual", IsCurrent=true},
                new EarnedIncome{ UserId=823, IncomeTitle="Plumber", IncomeAmount=3000, Frequency="Annual", IsCurrent=true},
                new EarnedIncome{ UserId=823, IncomeTitle="Writer", IncomeAmount=2250, Frequency="Annual", IsCurrent=true}
            };

            newEarnedIncome.Add(new EarnedIncome{ 
                UserId=income.UserId, 
                IncomeTitle=income.IncomeTitle, 
                IncomeAmount=income.IncomeAmount,
                Frequency=income.Frequency,
                IsCurrent=true
                });

            return newEarnedIncome;
        }

        public bool SaveChanges()
        {
            return true;
        }
    }
}