using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockRentalIncomeRepo : IRentalIncomeRepo
    {
        public void AddRentalProperty()
        {
            throw new System.NotImplementedException();
        }

        public void EditRentalProperty()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RentalIncome> GetAllRentalProperties()
        {
            throw new System.NotImplementedException();
        }
    }
}
