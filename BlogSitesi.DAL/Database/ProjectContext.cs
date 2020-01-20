using BlogSitesi.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BlogSitesi.DAL.Mapping;

namespace BlogSitesi.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("DefaultConnection")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance; //TODO TERRIBLE HACK DIYE GECIYOR
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContactPageMappings());
            modelBuilder.Configurations.Add(new AboutPageMappings());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AboutPage> AboutPage { get; set; }

        public DbSet<ContactPage> ContactPage { get; set; }
    }
}
