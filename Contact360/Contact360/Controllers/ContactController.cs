using Microsoft.AspNetCore.Mvc;

namespace Contact360.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
