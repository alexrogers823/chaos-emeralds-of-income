using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/Login")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;

        public UserController(IUserRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<User> LoginUser(string username, string password)
        {
            var user = _repo.LoginUser(username, password);
            return Ok(user);
        }

        [HttpGet]
        public ActionResult<User> LoginUser(string example)
        {
            var exampleUser = _repo.LoginUser(example);
            return Ok(exampleUser);
        }
    }
}