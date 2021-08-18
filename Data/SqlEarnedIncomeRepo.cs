using System;
using System.Collections.Generic;
using System.Linq;
using ChaosEmeraldsOfIncome.Data;
using ChaosEmeraldsOfIncome.Models;

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
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEarnedIncome(EarnedIncome income)
        {

        }
    }
}