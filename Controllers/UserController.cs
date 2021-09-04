using AutoMapper;
using ChaosEmeraldsOfIncome.Data;
using ChaosEmeraldsOfIncome.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ChaosEmeraldsOfIncome.Controllers
{
    [ApiController]
    [Route("api/Login")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        private readonly IMapper _mapper;

        public UserController(IUserRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
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

        // [HttpPatch("{id}")]
        // public ActionResult EditUser(int id, JsonPatchDocument<UserUpdateDto> patchDoc)
        // {
        //     // var userModel = _repo.EditUser(id); //Get User by Id
        //     if (userModel == null)
        //     {
        //         return NotFound();
        //     }

        //     var userPatch = _mapper.Map<UserUpdateDto>(userModel);
        //     patchDoc.ApplyTo(userPatch, ModelState);

        //     if (!TryValidateModel(userPatch))
        //     {
        //         return ValidationProblem(ModelState);
        //     }

        //     _mapper.Map(userPatch, userModel);
        //     _repo.EditUser(userModel);
        //     _repo.SaveChanges();

        //     return NoContent();
        // }
    }
}