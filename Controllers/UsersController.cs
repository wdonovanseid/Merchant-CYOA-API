using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CYOA_Merchant_API.Services;
using CYOA_Merchant_API.Models;
using System.Collections.Generic;

namespace CYOA_Merchant_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            User user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<User> users =  _userService.GetAll();
            return Ok(users);
        }
    }
}
