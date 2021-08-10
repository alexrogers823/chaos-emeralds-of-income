using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IEarnedIncomeRepo
    {
        IEnumerable<EarnedIncome> GetEarnedIncome();
        // EarnedIncome InsertEarnedIncome(EarnedIncome income);

        EarnedIncome GetEarnedIncomeById(int id);
        IEnumerable<EarnedIncome> InsertEarnedIncome(EarnedIncome income); // temporary

        void UpdateEarnedIncome(EarnedIncome income);
        bool SaveChanges();
    }
}