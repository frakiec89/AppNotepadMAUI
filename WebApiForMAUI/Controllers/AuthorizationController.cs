using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiForMAUI.ModelApi;

namespace WebApiForMAUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        [HttpPost("logIn")]
        public ActionResult<UserRespons> GetUser(UserRequst respons)
        {
            return Ok( new UserRespons () { Id = 1 , UserName="test"});
        }
    }
}
