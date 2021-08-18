using ChaosEmeraldsOfIncome.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/Notes")]
    public class NoteController : ControllerBase
    {
        private readonly INoteRepo _repo;

        public NoteController(INoteRepo repo)
        {
            _repo = repo;
        }   
    }
}