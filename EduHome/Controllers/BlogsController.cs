using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class BlogsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}