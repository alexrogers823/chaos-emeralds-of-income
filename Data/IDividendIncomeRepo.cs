using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface IDividendIncomeRepo
    {
        IEnumerable<DividendIncome> GetDividendIncome();
        void AddDividendIncome();
        bool SaveChanges();
    }
}
