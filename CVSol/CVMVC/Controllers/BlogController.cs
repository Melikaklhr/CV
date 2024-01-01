using Microsoft.AspNetCore.Mvc;

namespace CVMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View("BlogView");
        }
    }
}
