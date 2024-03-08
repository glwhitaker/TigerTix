using Microsoft.AspNetCore.Mvc;

namespace TigerTix.Controllers
{
    public class Profile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
