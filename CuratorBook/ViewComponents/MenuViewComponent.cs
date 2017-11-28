using CuratorBook.Models;
using CuratorBookCore.Contract.MainService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CuratorBook.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        protected IMainService Service = new MainService();

        public IViewComponentResult Invoke()
        {
            var guestRole = Service.GetDefaultRole();
            var pages = Service.GetListPages(guestRole);
            return View("Menu", pages);
        }

    }
}
