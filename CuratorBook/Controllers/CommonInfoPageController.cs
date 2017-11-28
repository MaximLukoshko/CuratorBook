using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CuratorBook.Models;

namespace CuratorBook.Controllers
{
    public class CommonInfoPageController : HomeController
    {
        public IActionResult Index(int id)
        {
            var guestRole = Service.GetDefaultRole();
            InitMenu(guestRole);

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