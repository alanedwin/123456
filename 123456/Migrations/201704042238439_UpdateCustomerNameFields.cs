namespace _123456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerNameFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ForeName", c => c.String());
            AddColumn("dbo.Customers", "Surname", c => c.String());
            DropColumn("dbo.Customers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "Surname");
            DropColumn("dbo.Customers", "ForeName");
        }
    }
}
