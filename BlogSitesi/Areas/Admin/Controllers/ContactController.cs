using System.Web.Mvc;
using BlogSitesi.Extensions;
using BlogSitesi.Models;
using BlogSitesi.Services;

namespace BlogSitesi.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        private ContactPageService _contactPageService;

        public ContactController()
        {
             _contactPageService=new ContactPageService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var contact = _contactPageService.GetContactPage();

            var viewModel = contact.GetContactViewModel(); 
        
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var contactModel = _contactPageService.GetContactPage();

            var contactViewModel = contactModel.GetContactViewModel();

            return View(contactViewModel);
        }

        [HttpPost]
        public ActionResult Edit(ContactViewModel contactViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("TitleName","İçeriği düzenleyebilmek için gerekli tüm alanları doldurmanız gerekmektedir.");
                return View();
            }

            var contactPage = contactViewModel.GetContactPage();
            _contactPageService.UpdateContact(contactPage);
            return RedirectToAction("Index");
        }

    }
}