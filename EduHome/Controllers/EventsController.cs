using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class EventsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}