using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IEarnedIncomeRepo
    {
        IEnumerable<EarnedIncome> GetEarnedIncome();
        // EarnedIncome InsertEarnedIncome(EarnedIncome income);

        EarnedIncome GetEarnedIncomeById(int id);
        void InsertEarnedIncome(EarnedIncome income);

        void UpdateEarnedIncome(EarnedIncome income);
        bool SaveChanges();
    }
}