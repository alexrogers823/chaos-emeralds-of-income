using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockBusinessIncomeRepo : IBusinessIncomeRepo
    {
        public void AddBusiness()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BusinessIncome> GetAllBusinessIncome()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBusiness()
        {
            throw new System.NotImplementedException();
        }
    }
}
