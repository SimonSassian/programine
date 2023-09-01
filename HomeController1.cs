using Microsoft.AspNetCore.Mvc;

namespace Nimetu.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
