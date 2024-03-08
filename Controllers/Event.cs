using Microsoft.AspNetCore.Mvc;

namespace TigerTix.Controllers
{
    public class Event : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
