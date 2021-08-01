using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IRoyaltyIncomeRepo
    {
        IEnumerable<RoyaltyIncome> GetAllRoyaltyIncome();
        void AddRoyalty();
        void UpdateRoyalty();
        bool SaveChanges();
    }
}
