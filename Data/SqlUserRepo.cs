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
        public void AddUser()
        {
            throw new System.NotImplementedException();
        }

        public User LoginUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(p => p.Name == username);
        }

        public User LoginUser(string example)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}