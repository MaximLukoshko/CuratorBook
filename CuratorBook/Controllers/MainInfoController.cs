using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CuratorBook.Models;
using CuratorBookCore.Contract.MainService;

namespace CuratorBook.Controllers
{
    public class MainInfoController : Controller
    {
        protected IMainService Service = new MainService();


        //Example
        /*[Authorize]
        public IActionResult Index()
        {
            return Content(User.Identity.Name);
        }*/
        public IActionResult Index()
        {
            var guestRole = Service.GetDefaultRole();
            var pages = Service.GetListPages(guestRole);
            return View();
        }

        public IActionResult Title()
        {
            return View();
        }

        public IActionResult BSUEducationFreeInformation()
        {
            return View();
        }

        public IActionResult BSULeadership()
        {
            return View();
        }

        public IActionResult BSUStudentsAssembly()
        {
            return View();
        }

        public IActionResult BSUInnerRules()
        {
            return View();
        }

        public IActionResult DiscountsForEducation()
        {
            return View();
        }

        public IActionResult PsychologicalServiceBSU()
        {
            return View();
        }

        public IActionResult BSUClubsSections()
        {
            return View();
        }

        public IActionResult CreativeClub()
        {
            return View();
        }

        public IActionResult Educationalcenter()
        {
            return View();
        }

        public IActionResult FinanceAssistance()
        {
            return View();
        }

        public IActionResult Anthem()
        {
            return View();
        }

        public IActionResult CodexRB()
        {
            return View();
        }

        public IActionResult HolidaysRB()
        {
            return View();
        }

        public IActionResult StudentsCharacteristic()
        {
            return View();
        }

        public IActionResult GroupEducationProcess()
        {
            return View();
        }

        public IActionResult CuratorWorkInstruction()
        {
            return View();
        }

        public IActionResult GroupCurator()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
