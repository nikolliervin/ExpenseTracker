﻿using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
