using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface IInterestIncomeRepo
    {
        IEnumerable<InterestIncome> GetAllInterestIncome();
        InterestIncome GetInterestIncomeById(int id);
        InterestIncome ArchiveInterestIncome(InterestIncome incomeObj);
        void AddInterestIncome(InterestIncome newIncome);
        void UpdateInterestIncome(InterestIncome incomeObj);
        bool SaveChanges();
    }
}