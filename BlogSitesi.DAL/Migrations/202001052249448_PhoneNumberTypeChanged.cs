namespace BlogSitesi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneNumberTypeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("blog.Contact", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("blog.Contact", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
