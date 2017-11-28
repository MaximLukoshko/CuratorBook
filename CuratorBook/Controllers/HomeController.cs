using Microsoft.AspNetCore.Mvc;
using CuratorBookCore.Contract.MainService;

namespace CuratorBook.Controllers
{
    public class HomeController : Controller
    {
        protected IMainService Service = new MainService();
    }
}
