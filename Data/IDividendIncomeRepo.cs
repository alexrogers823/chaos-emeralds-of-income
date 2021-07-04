using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IDividendIncomeRepo
    {
        IEnumerable<DividendIncome> GetDividendIncome();
        void AddDividendIncome();
    }
}
