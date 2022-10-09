using Microsoft.AspNetCore.Mvc;

namespace BorrowLanded.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
