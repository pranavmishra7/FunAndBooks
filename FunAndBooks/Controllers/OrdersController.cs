using Microsoft.AspNetCore.Mvc;

namespace FunAndBooks.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[Controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        [HttpGet]
        [Route("get/{orderId}")]
        [MapToApiVersion("1.0")]
        public IActionResult Get(int orderId)
        {
            return View();
        }
    }
}
