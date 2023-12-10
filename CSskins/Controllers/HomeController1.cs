using Microsoft.AspNetCore.Mvc;

namespace CSskins.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
