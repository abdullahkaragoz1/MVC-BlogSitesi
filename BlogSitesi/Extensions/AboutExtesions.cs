using BlogSitesi.Entities;
using BlogSitesi.Models;

namespace BlogSitesi.Extensions
{
    public static class AboutExtesions
    {

        public static AboutViewModel GetAboutViewModel(this AboutPage aboutPage)
        {
            var aboutViewModel = new AboutViewModel
            {
                Id = aboutPage.Id,
                TitleName = aboutPage.TitleName, 
                AboutDescription = aboutPage.AboutDescription
            };

            return aboutViewModel;
        }

        public static AboutPage GetAboutPage(this AboutViewModel viewModel)
        {
            var aboutPage = new AboutPage
            {
                Id = viewModel.Id,
                TitleName = viewModel.TitleName,
                AboutDescription = viewModel.AboutDescription
            };
            return aboutPage;
        }

         
    }
}