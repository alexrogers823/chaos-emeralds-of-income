using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IInterestIncomeRepo
    {
        IEnumerable<InterestIncome> GetAllInterestIncome();
    }
}