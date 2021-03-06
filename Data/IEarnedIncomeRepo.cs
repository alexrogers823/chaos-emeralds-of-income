using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface IEarnedIncomeRepo
    {
        IEnumerable<EarnedIncome> GetEarnedIncome();
        // EarnedIncome InsertEarnedIncome(EarnedIncome income);

        EarnedIncome GetEarnedIncomeById(int id);
        EarnedIncome ArchiveEarnedIncome(EarnedIncome income);
        void InsertEarnedIncome(EarnedIncome income);

        void UpdateEarnedIncome(EarnedIncome income);
        bool SaveChanges();
    }
}