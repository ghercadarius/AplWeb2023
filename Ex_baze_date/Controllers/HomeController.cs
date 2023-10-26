using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Ex_baze_date.Controllers
{
    [Route("api/[controller]")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
