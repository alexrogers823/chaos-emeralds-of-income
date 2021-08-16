using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IDividendIncomeRepo
    {
        IEnumerable<DividendIncome> GetDividendIncome();
        void AddDividendIncome();
        bool SaveChanges();
    }
}
