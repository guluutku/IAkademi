using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.Controllers
{
    public class MainMenuController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LogOut()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult DetailedSearch()
        {
            return View();
        }
    }
}