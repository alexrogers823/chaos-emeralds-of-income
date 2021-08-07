using System;
using System.Collections.Generic;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class MockInterestIncomeRepo : IInterestIncomeRepo
    {
        public void AddInterestIncome(InterestIncome newIncome)
        {
            if (newIncome == null)
            {
                throw new ArgumentNullException();
            }

        }

        public IEnumerable<InterestIncome> GetAllInterestIncome()
        {
            var interestIncome = new List<InterestIncome>
            {
                new InterestIncome{UserId=823, Name="Wells Fargo", InterestPercent=0.015, InterestDollar=26, IsActive=true},
                new InterestIncome{UserId=823, Name="Discover", InterestPercent=0.024, InterestDollar=52, IsActive=true},
                new InterestIncome{UserId=823, Name="Capital One", InterestPercent=0.027, InterestDollar=36, IsActive=true},
                new InterestIncome{UserId=823, Name="Ally", InterestPercent=0.019, InterestDollar=18, IsActive=true}
            };

            return interestIncome;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateInterestIncome(InterestIncome incomeObj)
        {
            throw new System.NotImplementedException();
        }
    }
}