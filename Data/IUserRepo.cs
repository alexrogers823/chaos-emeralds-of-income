using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface IUserRepo
    {
        User LoginUser(string username, string password);
        User LoginUser(string example);
        User LogoutUser();
        bool SetExampleUser(string example);
        void AddUser();
        bool SaveChanges();
    }
}