using Microsoft.AspNetCore.Mvc;

namespace CVMVC.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View("Portfolio");
        }
    }
}
