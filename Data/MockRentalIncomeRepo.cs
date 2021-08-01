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
            var properties = new List<RentalIncome> 
            {
                new RentalIncome{ Id=1, Property="Lofts at Summerhill", Mortgage=2850.00, Rent=3250, Frequency="Monthly"},
                new RentalIncome{ Id=2, Property="Springwood Flats", Mortgage=1675.25, Rent=2200, Frequency="Monthly"},
                new RentalIncome{ Id=3, Property="Wintergreen Apartments", Mortgage=875.00, Rent=1000, Frequency="Monthly"}
            };

            return properties;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
