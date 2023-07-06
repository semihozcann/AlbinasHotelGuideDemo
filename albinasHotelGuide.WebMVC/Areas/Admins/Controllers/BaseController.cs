using albinasHotelGuide.WebMVC.Helpers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace albinasHotelGuide.WebMVC.Areas.Admins.Controllers
{
    public class BaseController : Controller
    {
        IUserAccessor _userAccessor;
        public BaseController(IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }

        public Entities.Concrete.User CurrentUser
        {
            get
            {
                if (User != null)
                {
                    return _userAccessor.GetUser();
                }
                else
                {
                    return null;
                }
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
