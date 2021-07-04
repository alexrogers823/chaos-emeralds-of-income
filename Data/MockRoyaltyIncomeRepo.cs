using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockRoyaltyIncomeRepo : IRoyaltyIncomeRepo
    {
        public void AddRoyalty()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RoyaltyIncome> GetAllRoyaltyIncome()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateRoyalty()
        {
            throw new System.NotImplementedException();
        }
    }
}
