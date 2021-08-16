using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

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
                new CapitalGains{Id=1, Investment="QQQ", InitialSellValue=923.84, CurrentValue=1086.54},
                new CapitalGains{Id=1, Investment="SPGRX", InitialSellValue=421.50, CurrentValue=337.52},
                new CapitalGains{Id=1, Investment="MSFT", InitialSellValue=503.14, CurrentValue=545.22}
            };

            return capitalGains;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
