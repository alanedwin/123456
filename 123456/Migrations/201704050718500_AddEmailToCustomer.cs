namespace _123456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Email", c => c.String());
            RenameColumn("dbo.Customers", "image", "Image");
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "Email");
            RenameColumn("dbo.Customers", "Image", "image");
        }
    }
}
