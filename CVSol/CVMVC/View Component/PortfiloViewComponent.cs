using Microsoft.AspNetCore.Mvc;

namespace CVMVC.View_Component
{
    public class PortfiloViewComponent:ViewComponent
    { // call INVOLK method
        public IViewComponentResult Invoke() 
        {
            //this mothde return special view component that designed in view folder
            return View("PortfolioSingleView");
        }
    }
}
