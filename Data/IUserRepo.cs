using ChaosEmeraldsOfIncome.Models;

namespace ChaosEmeraldsOfIncome.Data
{
    public interface IUserRepo
    {
        User LoginUser(string username, string password);
        User LoginUser(string example);
        User LogoutUser();
        User GetUserById(int id);
        void EditUser(User user);
        bool SetExampleUser(string example);
        void AddUser(User userObj);
        bool SaveChanges();
    }
}