using JWT_User_Log_Reg_Auth.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_User_Log_Reg_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static UserModel user = new UserModel();

        [HttpPost("reguster")]
        public async Task<ActionResult<UserModel>>Register(UserDtoModel request)
        {
            return Ok();
        }
    }
}
