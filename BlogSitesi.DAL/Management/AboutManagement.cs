using System.Data.Entity;
using System.Linq;
using BlogSitesi.DAL.Database;
using BlogSitesi.Entities;

namespace BlogSitesi.DAL.Management
{
    public class AboutManagement
    {
        private ProjectContext database;

        public AboutManagement()
        {
            database = new ProjectContext();
        }

        public AboutPage GetAboutPage()
        {
            var aboutPage = database.AboutPage.FirstOrDefault();

            return aboutPage;
        }

        public bool  EditAboutPage(AboutPage aboutPage)
        {
            database.Entry(aboutPage).State = EntityState.Modified;
            var resultCount = database.SaveChanges();

            return resultCount > 0;
        }

    }
}
