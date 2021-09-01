using System;
using System.Linq;
using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly CEOIContext _context;

        public SqlUserRepo(CEOIContext context)
        {
            _context = context;
        }
        public void AddUser(User userObj)
        {
            if (userObj == null)
            {
                throw new ArgumentNullException();
            }

            _context.Users.Add(userObj);
        }

        public User LoginUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(p => p.Name == username);
        }

        public User LoginUser(string example)
        {
            return _context.Users.FirstOrDefault(p => p.Name == "Nonya Business");
        }

        public User LogoutUser()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public bool SetExampleUser(string example)
        {
            return example != null;
        }
    }
}