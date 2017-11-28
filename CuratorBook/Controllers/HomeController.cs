using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CuratorBook.Models;
using CuratorBookCore.Contract.MainService;
using CuratorBookCore.Data.Tables;

namespace CuratorBook.Controllers
{
    public class HomeController : Controller
    {
        protected IMainService Service = new MainService();

        protected void InitMenu(Roles role)
        {
            var pages = Service.GetListPages(role);
            var menuModel = new MenuModel() { Pages = pages };
            ViewData["Menu"] = menuModel;
        }

        public IActionResult Menu()
        {
            var guestRole = Service.GetDefaultRole();
            var pages = Service.GetListPages(guestRole);
            var menuModel = new MenuModel() { Pages = pages };
            return PartialView("_Menu", menuModel);
        }
    }
}
