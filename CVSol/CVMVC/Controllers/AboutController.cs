using Microsoft.AspNetCore.Mvc;

namespace CVMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View("About");
        }
    }
}
