using System.Web.Mvc;
using BlogSitesi.Extensions;
using BlogSitesi.Services;


namespace BlogSitesi.Controllers
{
    public class HomeController : Controller
    {

        private readonly AboutPageService _aboutPageService;
        private readonly ContactPageService _contactPageService;

        public HomeController()
        {
                _aboutPageService=new AboutPageService();
                _contactPageService=new ContactPageService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public ActionResult About()
        {
            var about = _aboutPageService.GeAboutPage();
            var viewModel = about.GetAboutViewModel();

            return View(viewModel);
        }


        [HttpGet]
        public ActionResult Contact()
        {
            var contact = _contactPageService.GetContactPage();
            var viewModel = contact.GetContactViewModel();

            return View(viewModel);

        }
    }
}