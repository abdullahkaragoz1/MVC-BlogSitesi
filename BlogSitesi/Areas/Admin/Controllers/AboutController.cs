using System.Web.Mvc;
using BlogSitesi.Extensions;
using BlogSitesi.Models;
using BlogSitesi.Services;

namespace BlogSitesi.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        private AboutPageService _aboutPageService;

        public AboutController()
        {
            _aboutPageService = new AboutPageService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var about = _aboutPageService.GeAboutPage();

            var viewModel = about.GetAboutViewModel();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var aboutModel = _aboutPageService.GeAboutPage();

            var aboutViewModel = aboutModel.GetAboutViewModel();

            return View(aboutViewModel);
        }

        [HttpPost]
        public ActionResult Edit(AboutViewModel aboutViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("TitleName","İçeriği düzenleyebilmek için gerekli tüm alanları doldurmanız gerekmektedir");
                return View();
            }

            var aboutPage = aboutViewModel.GetAboutPage();
            _aboutPageService.UpdateAbout(aboutPage);
            return RedirectToAction("Index");
        }


    }
}