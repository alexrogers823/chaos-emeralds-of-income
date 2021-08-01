namespace ChaosEmeraldsOfIncome.Controllers
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