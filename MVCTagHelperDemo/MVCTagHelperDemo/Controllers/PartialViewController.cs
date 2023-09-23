using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelperDemo.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and jerry are good freinds";
            return View();
        }
        public IActionResult ChildList()
        {
            return View();
        }
        public IActionResult ChildViewdata()
        {
            return View();
        }
        public IActionResult Score()
        {
            return View();
        }
        public IActionResult MyView()
        {
            return View();
        }
    }
}
