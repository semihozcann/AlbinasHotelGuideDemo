using Microsoft.AspNetCore.Mvc;

namespace albinasHotelGuide.WebMVC.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
