using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class TeachersController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}