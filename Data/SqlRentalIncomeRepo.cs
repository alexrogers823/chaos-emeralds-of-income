using System.Collections.Generic;
using System.Linq;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class SqlRentalIncomeRepo : IRentalIncomeRepo
    {
        private readonly CEOIContext _context;

        public SqlRentalIncomeRepo(CEOIContext context)
        {
            _context = context;
        }
        public void AddRentalProperty()
        {
            throw new System.NotImplementedException();
        }

        public void EditRentalProperty()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RentalIncome> GetAllRentalProperties()
        {
            return _context.RentalIncome.ToList();
        }
    }
}