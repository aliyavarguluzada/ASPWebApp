using Microsoft.AspNetCore.Mvc;

namespace ASPWebApp.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Company()
        {
            return View();
        }
    }
}
