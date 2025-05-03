using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apis11od.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lastApiController : ControllerBase
    {
        [HttpGet]
        public string GetMyName()
        {
            return "Moath is good";
        }
    }
}
