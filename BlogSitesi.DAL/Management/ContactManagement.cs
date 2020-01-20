using System.Data.Entity;
using System.Linq;
using BlogSitesi.DAL.Database;
using BlogSitesi.Entities;

namespace BlogSitesi.DAL.Management
{
    public class ContactManagement
    {
        private ProjectContext database;

        public ContactManagement()
        {
            database=new ProjectContext();       
        }

        public ContactPage GetContactPage()
        {
            var contactPage = database.ContactPage.FirstOrDefault();

            return contactPage;
        }

        public bool EditContactPage(ContactPage contactPage)
        {
            database.Entry(contactPage).State = EntityState.Modified;
            var resultCount = database.SaveChanges();

            return resultCount > 0;
        }
    }
}