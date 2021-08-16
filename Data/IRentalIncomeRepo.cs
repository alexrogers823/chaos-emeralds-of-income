using System.Collections.Generic;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IRentalIncomeRepo
    {
        IEnumerable<RentalIncome> GetAllRentalProperties();
        void AddRentalProperty();
        void EditRentalProperty();
        bool SaveChanges();
    }
}
