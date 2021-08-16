using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockDividendIncomeRepo : IDividendIncomeRepo
    {
        public void AddDividendIncome()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DividendIncome> GetDividendIncome()
        {
            var dividendIncome = new List<DividendIncome>
            {
                new DividendIncome{Id=101, InvestmentId=31, DividendPayout=450},
                new DividendIncome{Id=102, InvestmentId=31, DividendPayout=625},
                new DividendIncome{Id=103, InvestmentId=32, DividendPayout=200},
                new DividendIncome{Id=104, InvestmentId=33, DividendPayout=125}
            };

            return dividendIncome;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
