namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IUserRepo
    {
        User LoginUser(string username, string password);
        User LogoutUser();
        bool SetExampleUser(string example);
        void AddUser();
    }
}