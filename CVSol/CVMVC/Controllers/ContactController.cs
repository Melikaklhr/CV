using Microsoft.AspNetCore.Mvc;

namespace CVMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View("Contact");
        }
    }
}
