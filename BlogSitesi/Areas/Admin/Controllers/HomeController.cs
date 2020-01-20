using System.Web.Mvc;

namespace BlogSitesi.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}