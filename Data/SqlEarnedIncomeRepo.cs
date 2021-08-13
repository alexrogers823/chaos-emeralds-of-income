using System;
using System.Collections.Generic;
using System.Linq;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class SqlEarnedIncomeRepo : IEarnedIncomeRepo
    {
        private readonly CEOIContext _context;

        public SqlEarnedIncomeRepo(CEOIContext context)
        {
            _context = context;
        }
        public IEnumerable<EarnedIncome> GetEarnedIncome()
        {
            return _context.EarnedIncome.ToList();
        }

        public EarnedIncome GetEarnedIncomeById(int id)
        {
            return _context.EarnedIncome.FirstOrDefault(p => p.Id == id);
        }

        // change this to void 
        public void InsertEarnedIncome(EarnedIncome income)
        {
            if (income == null)
            {
                throw new ArgumentNullException(nameof(income));
            }

            _context.EarnedIncome.Add(income);

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateEarnedIncome(EarnedIncome income)
        {
            throw new NotImplementedException();
        }
    }
}