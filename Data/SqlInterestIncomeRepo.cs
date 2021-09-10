using System;
using System.Collections.Generic;
using System.Linq;
using ChaosEmeraldsOfIncome.Data;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class SqlInterestIncomeRepo : IInterestIncomeRepo
    {
        private readonly CEOIContext _context;

        public SqlInterestIncomeRepo(CEOIContext context)
        {
            _context = context;
        }

        public void AddInterestIncome(InterestIncome newIncome)
        {
            if (newIncome == null)
            {
                throw new ArgumentNullException();
            }

            _context.InterestIncome.Add(newIncome);
        }

        public InterestIncome ArchiveInterestIncome(InterestIncome incomeObj)
        {
            return new InterestIncome
            {
                Id=incomeObj.Id,
                UserId=incomeObj.UserId,
                Name=incomeObj.Name,
                TotalSavings=incomeObj.TotalSavings,
                InterestPercent=incomeObj.InterestPercent,
                InterestDollar=incomeObj.InterestDollar,
                IsActive=false
            };
        }

        public IEnumerable<InterestIncome> GetAllInterestIncome()
        {
            bool showArchived = false; //temporary

            IEnumerable<InterestIncome> query = _context.InterestIncome
                // .Where(p => p.User == user) // retrieve only for logged in user
                .OrderByDescending(p => p.InterestDollar);

            if (!showArchived) {
                query = query.Where(p => p.IsActive == true);
            };
            
            return query.ToList();
        }

        public InterestIncome GetInterestIncomeById(int id)
        {
            if (id != null)
            {
                return _context.InterestIncome.FirstOrDefault(p => p.Id == id);
            }

            throw new ArgumentNullException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateInterestIncome(InterestIncome incomeObj)
        {
            throw new System.NotImplementedException();
        }
    }
}