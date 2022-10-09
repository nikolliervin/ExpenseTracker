using BorrowLanded.Data;
using BorrowLanded.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BorrowLanded.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Item;
            return View(objList);
        }

        //GET- Create
        public IActionResult Create()
        {
            return View();
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Item.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
