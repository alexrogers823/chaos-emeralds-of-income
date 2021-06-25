namespace ChaosEmeraldsOfIncome.Controllers
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

        public User LogoutUser()
        {
            throw new System.NotImplementedException();
        }

        public bool SetExampleUser(string example)
        {
            throw new System.NotImplementedException();
        }
    }
}