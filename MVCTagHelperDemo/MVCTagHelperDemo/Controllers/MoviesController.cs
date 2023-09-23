using Microsoft.AspNetCore.Mvc;

namespace MVCTagHelperDemo.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Start()
        {
            return View();
        }
    }
}
// write for calling - Movies/Start ...It will give Movielist & Booklist