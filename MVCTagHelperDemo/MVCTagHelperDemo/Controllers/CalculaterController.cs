using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelperDemo.Controllers
{
    public class CalculaterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
