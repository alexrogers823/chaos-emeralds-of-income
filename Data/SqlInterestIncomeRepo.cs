using System.Collections.Generic;
using System.Linq;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class SqlInterestIncomeRepo : IInterestIncomeRepo
    {
        private readonly CEOIContext _context;

        public SqlInterestIncomeRepo(CEOIContext context)
        {
            _context = context;
        }
        public IEnumerable<InterestIncome> GetAllInterestIncome()
        {
            return _context.InterestIncome.ToList();
        }
    }
}