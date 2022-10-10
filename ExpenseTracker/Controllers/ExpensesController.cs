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

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Expenses obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Post Delete

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                _db.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }



        }

        //Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var obj = _db.Expenses.Find(id);

            if (obj == null)
                return NotFound();
            return View(obj);
        }


    }
}
