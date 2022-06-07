using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class ContactsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}