namespace _123456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "image");
        }
    }
}
