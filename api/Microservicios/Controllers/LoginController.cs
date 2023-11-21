using Microsoft.AspNetCore.Mvc;

namespace Microservicios.Controllers
{

    [Route("lhs")]
    [ApiController]

    public class LoginController : Controller
    {
        [HttpPost]
        [Route("Login")]
        public dynamic Login()
        {
            try
            {
                return new { };
            }
            catch (Exception ex) 
            {
                return ex;
            }
        }
    }
}
