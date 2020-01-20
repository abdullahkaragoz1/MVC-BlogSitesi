using System.Data.Entity.ModelConfiguration;
using BlogSitesi.Entities;

namespace BlogSitesi.DAL.Mapping
{
    public class ContactPageMappings : EntityTypeConfiguration<ContactPage>
    {
        public ContactPageMappings()
        {
            ToTable("Contact", "blog");
        }



    }
}
