using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockCapitalGainsRepo : ICapitalGainsRepo
    {
        public void AddCapitalGain()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CapitalGains> GetAllCapitalGains()
        {
            throw new System.NotImplementedException();
        }
    }
}
