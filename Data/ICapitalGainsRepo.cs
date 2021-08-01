using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface ICapitalGainsRepo
    {
        IEnumerable<CapitalGains> GetAllCapitalGains();
        void AddCapitalGain();
        bool SaveChanges();
    }
}
