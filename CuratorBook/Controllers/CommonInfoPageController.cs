using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CuratorBook.Models;

namespace CuratorBook.Controllers
{
    public class CommonInfoPageController : BaseCuratorController
    {
        public IActionResult Index(int id)
        {
            var guestRole = Service.GetDefaultRole();

            CommonInfoPageModel model = new CommonInfoPageModel()
            {
                ImageSrc = Service.GetPictureForCommonPage(id),
                PageId = id,
                PageName = Service.GetListPages(guestRole).SingleOrDefault(n => n.Id == id).Name
            };

            return View("CommonInfoPageView", model);
        }
    }
}