using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IEarnedIncomeRepo
    {
        IEnumerable<EarnedIncome> GetEarnedIncome();
        // EarnedIncome InsertEarnedIncome(EarnedIncome income);
        IEnumerable<EarnedIncome> InsertEarnedIncome(EarnedIncome income); // temporary
    }
}