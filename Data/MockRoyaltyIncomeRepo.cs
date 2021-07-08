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
            var royalties = new List<RoyaltyIncome>
            {
                new RoyaltyIncome{Id=10, Title="Horror Audiobook", Frequency="Monthly", Amount=25.5},
                new RoyaltyIncome{Id=20, Title="Evolv", Frequency="Monthly", Amount=15.25},
                new RoyaltyIncome{Id=30, Title="Wrong Side of Heaven", Frequency="Monthly", Amount=14}
            };

            return royalties;
        }

        public void UpdateRoyalty()
        {
            throw new System.NotImplementedException();
        }
    }
}
