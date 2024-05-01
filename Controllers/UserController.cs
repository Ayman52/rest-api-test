using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.EF_CORE;
using api.Helper;
using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(AppDbContext appDbContext)
        {
            _userService = new UserService(appDbContext); ;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                return Ok(users);
                // return Ok(new SuccessResponse<IEnumerable<UserModel>>
                // {
                //     Message = "Users are returned successfully",
                //     Data = users,
                // });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500, new ErrorResponse
                {
                    Message = e.Message
                });
            }
        }


        [HttpPost]
        public IActionResult CreateUser(UserModel newUser)
        {
            try
            {
                _userService.AddUser(newUser);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500, new ErrorResponse
                {
                    Message = e.Message
                });
            }
        }
    }
}