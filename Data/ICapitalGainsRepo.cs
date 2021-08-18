using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface ICapitalGainsRepo
    {
        IEnumerable<CapitalGains> GetAllCapitalGains();
        void AddCapitalGain();
        bool SaveChanges();
    }
}
