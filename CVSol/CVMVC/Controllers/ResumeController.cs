using Microsoft.AspNetCore.Mvc;

namespace CVMVC.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View("Resume");
        }
    }
}
