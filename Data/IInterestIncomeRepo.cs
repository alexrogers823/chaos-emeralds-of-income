using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface IInterestIncomeRepo
    {
        IEnumerable<InterestIncome> GetAllInterestIncome();
        InterestIncome GetInterestIncomeById(int id);
        void AddInterestIncome(InterestIncome newIncome);
        void UpdateInterestIncome(InterestIncome incomeObj);
        void ArchiveInterestIncome(InterestIncome incomeObj);
        bool SaveChanges();
    }
}