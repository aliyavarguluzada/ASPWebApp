using Microsoft.AspNetCore.Mvc;

namespace ASPWebApp.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Faq() 
        {
            return View();
        }
    }
}
