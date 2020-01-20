using System.Data.Entity.ModelConfiguration;
using BlogSitesi.Entities;

namespace BlogSitesi.DAL.Mapping
{
    public class AboutPageMappings : EntityTypeConfiguration<AboutPage>
    {

        public AboutPageMappings()
        {
            ToTable("About", "blog");
        }


    }
}
