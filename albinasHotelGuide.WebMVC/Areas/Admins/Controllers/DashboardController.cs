using albinasHotelGuide.WebMVC.Helpers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace albinasHotelGuide.WebMVC.Areas.Admins.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(IUserAccessor userAccessor) : base(userAccessor)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
