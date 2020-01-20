using System.Linq;
using BlogSitesi.Entities;

namespace BlogSitesi.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogSitesi.DAL.Database.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogSitesi.DAL.Database.ProjectContext context)
        {

            if (!context.AboutPage.Any())
            {
                var aboutPage = new AboutPage
                {
                    TitleName = "Bu seed ile gelen örnek baþlýk",
                    AboutDescription = "Seed ile gelen içerik"
                };
                context.AboutPage.Add(aboutPage);
                context.SaveChanges();
            }

            //if (!context.ContactPage.Any())
            //{
            //    var contactPage = new ContactPage
            //    {
            //        FullName = "Bu seed ile gelen örnek Ad",
            //        EmailAddress = "Seed ile gelen mail",
            //        PhoneNumber = "Seed ile gelen number"
            //    };
            //}



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
