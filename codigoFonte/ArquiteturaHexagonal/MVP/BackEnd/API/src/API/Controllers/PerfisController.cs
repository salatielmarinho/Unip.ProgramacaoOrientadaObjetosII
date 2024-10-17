using Microsoft.AspNetCore.Mvc;

namespace API.API.Controllers
{
    public class PerfisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
