using Microsoft.AspNetCore.Mvc;
using Portfolio.Dbcontext;
using Portfolio.Statuses;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        public UserController(UserDBContext _userDB)
        {
            this.userDB = _userDB;
        }
        private readonly UserDBContext userDB;


        [HttpGet("GetInfo")]
        public IActionResult AboutMe()
        {
            return Ok(new Status() { Massage = nameof(StatusType.Success), Data = userDB.Users });
        }

        [HttpGet("CV")] 
        public IActionResult GetCV()
        {
            return Ok(new Status() { Massage= nameof(StatusType.Success),Data = userDB.ResLink});
        }

        [HttpGet]
        public IActionResult Projects()
        {
            return Ok(new Status() { Massage = nameof(StatusType.Success), Data = userDB.Projs });
        }
    }
}
