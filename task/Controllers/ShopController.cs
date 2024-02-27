using Microsoft.AspNetCore.Mvc;

namespace task.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
