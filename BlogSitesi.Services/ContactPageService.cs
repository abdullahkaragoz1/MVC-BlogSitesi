using BlogSitesi.DAL.Management;
using BlogSitesi.Entities;

namespace BlogSitesi.Services
{
    public class ContactPageService
    {
        private ContactManagement _contactManagement;

        public ContactPageService()
        {
            _contactManagement=new ContactManagement();
        }

        public ContactPage GetContactPage()
        {
            var contactPage = _contactManagement.GetContactPage();

            return contactPage;
        }

        public void UpdateContact(ContactPage contactPage)
        {
            var result = _contactManagement.EditContactPage(contactPage);
        }
    }
}