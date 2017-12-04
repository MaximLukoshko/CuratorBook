using CuratorBookCore.Contract.MainService;
using Microsoft.AspNetCore.Mvc;

namespace CuratorBook.Controllers
{
    public class BaseCuratorController : Controller
    {
        protected IMainService Service = new MainService();
    }
}