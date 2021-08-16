using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IBusinessIncomeRepo
    {
        IEnumerable<BusinessIncome> GetAllBusinessIncome();
        void AddBusiness();
        void UpdateBusiness();
        bool SaveChanges();
    }
}
