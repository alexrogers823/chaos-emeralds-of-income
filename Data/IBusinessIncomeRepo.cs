using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IBusinessIncomeRepo
    {
        IEnumerable<BusinessIncome> GetAllBusinessIncome();
        void AddBusiness();
        void UpdateBusiness();
    }
}
