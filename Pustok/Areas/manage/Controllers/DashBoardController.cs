using Microsoft.AspNetCore.Mvc;

namespace Pustok.Areas.manage.Controllers
{
    [Area("manage")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
