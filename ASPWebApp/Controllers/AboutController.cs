using Microsoft.AspNetCore.Mvc;

namespace ASPWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
