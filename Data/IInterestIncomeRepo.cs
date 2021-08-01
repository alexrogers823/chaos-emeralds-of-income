using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IInterestIncomeRepo
    {
        IEnumerable<InterestIncome> GetAllInterestIncome();
        void AddInterestIncome(InterestIncome newIncome);
        void UpdateInterestIncome();
        bool SaveChanges();
    }
}