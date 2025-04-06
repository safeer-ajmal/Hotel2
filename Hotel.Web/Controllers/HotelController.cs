using Microsoft.AspNetCore.Mvc;

namespace Hotel.Web.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
