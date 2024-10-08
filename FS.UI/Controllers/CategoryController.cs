using Microsoft.AspNetCore.Mvc;

namespace FS.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
