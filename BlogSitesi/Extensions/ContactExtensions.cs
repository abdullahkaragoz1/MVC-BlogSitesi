using BlogSitesi.Entities;
using BlogSitesi.Models;

namespace BlogSitesi.Extensions
{
    public static class ContactExtensions
    {
        public static ContactViewModel GetContactViewModel(this ContactPage contactPage)
        {
            var contactViewModel = new ContactViewModel
            {
                Id = contactPage.Id,
                FullName = contactPage.FullName,
                EmailAddress = contactPage.EmailAddress,
                PhoneNumber = contactPage.PhoneNumber
            };
            return contactViewModel;
        }

        public static ContactPage GetContactPage(this ContactViewModel viewModel)
        {
            var contactPage = new ContactPage
            {
                Id = viewModel.Id,
                FullName = viewModel.FullName,
                EmailAddress = viewModel.EmailAddress,
                PhoneNumber = viewModel.PhoneNumber
            };
            return contactPage;
        }
    }
}