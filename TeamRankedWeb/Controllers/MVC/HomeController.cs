using System.Web.Mvc;

namespace TeamRankedWeb.Controllers.MVC
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
