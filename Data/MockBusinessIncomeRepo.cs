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
            var businesses = new List<BusinessIncome>
            {
                new BusinessIncome{Id=21, BusinessName="Rogers Incorporated", Revenue=10800, Expenses=4128, Profit=6672, IsCurrent=true},
                new BusinessIncome{Id=22, BusinessName="Virgocity", Revenue=18966, Expenses=11585, Profit=7381, IsCurrent=true},
                new BusinessIncome{Id=23, BusinessName="Sinners and Saints", Revenue=22540, Expenses=12400, Profit=10140, IsCurrent=true},
            };
            return businesses;
        }

        public void UpdateBusiness()
        {
            throw new System.NotImplementedException();
        }
    }
}
