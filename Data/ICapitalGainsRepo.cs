using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface ICapitalGainsRepo
    {
        IEnumerable<CapitalGains> GetAllCapitalGains();
        void AddCapitalGain();
        bool SaveChanges();
    }
}
