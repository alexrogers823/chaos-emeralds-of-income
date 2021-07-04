using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }
    }
}
