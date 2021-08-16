using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

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
