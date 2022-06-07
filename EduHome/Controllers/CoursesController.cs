using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class CoursesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}