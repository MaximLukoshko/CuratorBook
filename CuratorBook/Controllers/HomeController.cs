﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CuratorBook.Models;
using CuratorBookCore.Contract.MainService;

namespace CuratorBook.Controllers
{
    public class HomeController : Controller
    {
        protected IMainService Service = new MainService();

        public IActionResult Index()
        {
            var guestRole = Service.GetDefaultRole();
            var pages = Service.GetListPages(guestRole);
            var menuModel = new MenuModel() { Pages = pages };
            ViewData["Menu"] = menuModel;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
