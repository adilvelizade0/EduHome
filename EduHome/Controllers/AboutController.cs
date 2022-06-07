using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}