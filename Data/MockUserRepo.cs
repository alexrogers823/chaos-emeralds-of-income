using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public class MockUserRepo : IUserRepo
    {
        public void AddUser()
        {
            throw new System.NotImplementedException();
        }

        public User LoginUser(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public User LoginUser(string example)
        {
            if (SetExampleUser(example))
            {
                return new User{Id=0, Name="Sally", NetWorthGoal=1000000, Contribution=0.15, RetirementAge=65};
            }

            throw new System.NotImplementedException();
        }

        public User LogoutUser()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public bool SetExampleUser(string example)
        {
            if (example == "checked")
            {
                return true;
            }
            return false;
        }
    }
}