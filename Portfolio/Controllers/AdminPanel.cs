using Microsoft.AspNetCore.Mvc;
using Portfolio.Dbcontext;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminPanel:ControllerBase
    {
        public AdminPanel(UserDBContext _userDB)
        {
            this.userDB = _userDB;
        }
        private readonly UserDBContext userDB;
    }
}
