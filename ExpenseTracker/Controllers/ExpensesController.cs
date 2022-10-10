using BorrowLanded.Data;
using BorrowLanded.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BorrowLanded.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ExpensesController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expenses> objList = _db.Expenses;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Expenses obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
