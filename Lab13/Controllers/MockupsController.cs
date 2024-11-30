using Microsoft.AspNetCore.Mvc;

namespace Lab13.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View("index");
        }
    }
}
