using ChaosEmeraldsOfIncome.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/NetWorth")]
    public class NetWorthController : ControllerBase
    {
        private readonly INetWorthRepo _repo;

        public NetWorthController(INetWorthRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public void GetAllAssets()
        {
            _repo.GetAllAssets();
        }
    }
}