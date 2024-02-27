using Microsoft.AspNetCore.Mvc;
using task.Contexts;

namespace task.Controllers
{
    public class HomeController : Controller
    {
        public readonly PronioDbContext : Controller

        public HomeController(PronioDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sliders = _context.Sliders.ToList();

            return View(sliders);
        }
    }
}
