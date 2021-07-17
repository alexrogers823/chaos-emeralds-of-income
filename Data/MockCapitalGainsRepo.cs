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
            var capitalGains = new List<CapitalGains>
            {
                new CapitalGains{Id=1, Investment="QQQ", CurrentValue=1086.54},
                new CapitalGains{Id=1, Investment="SPGRX", CurrentValue=337.52},
                new CapitalGains{Id=1, Investment="MSFT", CurrentValue=545.22}
            };

            return capitalGains;
        }
    }
}
