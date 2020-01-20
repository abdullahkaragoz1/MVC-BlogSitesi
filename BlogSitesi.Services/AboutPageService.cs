using BlogSitesi.DAL.Management;
using BlogSitesi.Entities;

namespace BlogSitesi.Services
{
    public class AboutPageService
    {
        private AboutManagement _aboutManagement;

        public AboutPageService()
        {
            _aboutManagement = new AboutManagement();
        }

        public AboutPage GeAboutPage()
        {
            var aboutPage = _aboutManagement.GetAboutPage();

            return aboutPage;
        }

        public void UpdateAbout(AboutPage aboutPage)
        {
            var result = _aboutManagement.EditAboutPage(aboutPage);
        }
    }
}
