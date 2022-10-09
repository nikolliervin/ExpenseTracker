using Microsoft.AspNetCore.Mvc;

namespace BorrowLanded.Controllers
{
    public class ExpensesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
